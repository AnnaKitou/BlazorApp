using Blazored.Toast;
using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using Entities.Configuration;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace BlazorProducts.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
			var apiConfiguration = new ApiConfiguration();
			builder.Configuration.Bind("ApiConfiguration",apiConfiguration);

			builder.Services.AddHttpClient("ProductsAPI", (sp,cl) =>
			{
				cl.BaseAddress = new Uri(apiConfiguration.BaseAddress+"/api/");
				cl.EnableIntercept(sp);
			});

			builder.Services.AddBlazoredToast();

			builder.Services.AddScoped(
				sp => sp.GetService<IHttpClientFactory>().CreateClient("ProductsAPI"));
			builder.Services.AddHttpClientInterceptor();
			builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
			builder.Services.AddScoped<HttpInterceptorService>();
			await builder.Build().RunAsync();
		}
	}
}
