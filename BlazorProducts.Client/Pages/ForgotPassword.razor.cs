using BlazorProducts.Client.HttpRepository;
using Entities.DTO;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class ForgotPassword
    {
        private ForgotPasswordDto _forgotPassDto = new ForgotPasswordDto();
        private bool _showSuccess;
        private bool _showError;

        [Inject]
        private IAuthenticationService AuthService { get; set; }

        private async Task Submit()
        {
            _showSuccess = _showError = false;

            var result = await AuthService.ForgotPassword(_forgotPassDto);

            if (result == HttpStatusCode.OK)
                _showSuccess = true;
            else
                _showError = true;


        }
    }
}
