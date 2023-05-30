using Entities.DTO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;

        public AuthenticationService(HttpClient client)
        {
            _client = client;
        }

        public Task<ResponseDto> RegisterUser(UserForRegistrationDto userForRegistrationDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
