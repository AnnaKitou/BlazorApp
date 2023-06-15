using BlazorProducts.Client.HttpRepository;
using Entities.DTO;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Client.Pages
{
    public partial class Login
    {
		private UserForAuthenticationDto _userForAuthentication = new UserForAuthenticationDto();

		[Inject]
		public IAuthenticationService AuthenticationService { get; set; }

		[Inject]
		public NavigationManager NavigationManager { get; set; }

		public bool ShowAuthenticationErrors { get; set; }
		public string Error { get; set; }

		public async Task ExecuteLogin()
		{
			ShowAuthenticationErrors = false;

			var result = await AuthenticationService.Login(_userForAuthentication);
			if (!result.IsAuthSuccessful)
			{
				Error = result.ErrorMessage;
				ShowAuthenticationErrors = true;
			}
			else
			{
				NavigationManager.NavigateTo("/");
			}
		}
	}
}
