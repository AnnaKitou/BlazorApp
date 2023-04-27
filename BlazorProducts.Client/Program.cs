using BlazorProducts.Client.HttpInterceptor;
using BlazorProducts.Client.HttpRepository;
using Entities.Configuration;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Blazored.Toast;

namespace BlazorProducts.Client
{
    public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
			
			builder.Services.AddHttpClient("ProductsAPI", (sp,cl) =>
			{
				var apiConfiguration=sp.GetRequiredService<IOptions<ApiConfiguration>>();
				cl.BaseAddress = new Uri(apiConfiguration.Value.BaseAddress+"/api/");
				cl.EnableIntercept(sp);
			});

			builder.Services.AddBlazoredToast();

			builder.Services.AddScoped(
				sp => sp.GetService<IHttpClientFactory>().CreateClient("ProductsAPI"));
			builder.Services.AddHttpClientInterceptor();
			builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
			builder.Services.AddScoped<HttpInterceptorService>();

			builder.Services.Configure<ApiConfiguration>(builder.Configuration.GetSection("ApiConfiguration"));

			await builder.Build().RunAsync();
		}
	}
}
