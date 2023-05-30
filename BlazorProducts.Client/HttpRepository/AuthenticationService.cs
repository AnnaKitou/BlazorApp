using Entities.DTO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public AuthenticationService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ResponseDto> RegisterUser(UserForRegistrationDto userForRegistrationDto)
        {
            var response = await _client.PostAsJsonAsync("account/register", userForRegistrationDto);

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
