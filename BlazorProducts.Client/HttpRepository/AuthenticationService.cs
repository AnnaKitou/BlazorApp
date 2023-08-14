using Blazored.LocalStorage;
using BlazorProducts.Client.AuthProviders;
using Entities.DTO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly Blazored.LocalStorage.ILocalStorageService _localStorage;
        private readonly NavigationManager _navManager;
        public AuthenticationService(HttpClient client, AuthenticationStateProvider authStateProvider, Blazored.LocalStorage.ILocalStorageService localStorage, NavigationManager navManager)
        {
            _client = client;
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
            _navManager = navManager;
        }

        public async Task<HttpStatusCode> ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            forgotPasswordDto.ClientURI = Path.Combine(_navManager.BaseUri, "resetpassword");

            var result = await _client.PostAsJsonAsync("account/forgotpassword", forgotPasswordDto);

            return result.StatusCode;
        }

        public async Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication)
        {
            var response = await _client.PostAsJsonAsync("account/login", userForAuthentication);
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<AuthResponseDto>(content, _options);
            if (!response.IsSuccessStatusCode)
                return result;

            await _localStorage.SetItemAsync("authToken", result.Token);
            await _localStorage.SetItemAsync("refreshToken", result.RefreshToken);

            ((AuthStateProvider)_authStateProvider).NotifyAuthentication(
                result.Token);

            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                    "bearer", result.Token);

            return new AuthResponseDto { IsAuthSuccessful = true };
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            await _localStorage.RemoveItemAsync("refreshToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<string> RefereshToken()
        {
            var token = await _localStorage.GetItemAsync<string>("authtoken");
            var refreshToken = await _localStorage.GetItemAsync<string>("refreshToken");
            var response = await _client.PostAsJsonAsync("token/refresh",
                new RefreshTokenDto
                {
                    Token = token,
                    RefreshToken = refreshToken
                });

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<AuthResponseDto>(content, _options);

            await _localStorage.SetItemAsync("authtoken", result.Token);
            await _localStorage.SetItemAsync("refreshToken", result.RefreshToken);

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
                ("bearer", result.Token);

            return result.Token;
        }

        public async Task<ResponseDto> RegisterUser(UserForRegistrationDto userForRegistrationDto)
        {
            var response = await _client.PostAsJsonAsync("account/register",
                userForRegistrationDto);

            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<ResponseDto>(content, _options);

                return result;
            }

            return new ResponseDto { IsSuccessfulRegistration = true };
        }
    }
}
