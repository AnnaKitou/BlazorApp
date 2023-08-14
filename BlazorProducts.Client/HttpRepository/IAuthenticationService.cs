using Entities.DTO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
		Task<ResetPasswordResponseDto> ResetPassword(ResetPasswordDto resetPasswordDto);
		Task<HttpStatusCode> EmailConfirmation(string email, string token);
	}
}
