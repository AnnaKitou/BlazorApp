using Entities.DTO;
using System.Net;
using System.Threading.Tasks;

namespace BlazorProducts.Client.HttpRepository
{
    public interface IAuthenticationService
    {
        Task<ResponseDto> RegisterUser(UserForRegistrationDto userForRegistrationDto);
        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);
        Task Logout();
        Task<string> RefereshToken();
        Task<HttpStatusCode> ForgotPassword(ForgotPasswordDto forgotPasswordDto);
    }
}
