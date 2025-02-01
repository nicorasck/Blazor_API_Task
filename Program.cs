using Blazor_API_Task.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Blazor_API_Task;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        var NumberValidationApiKey = builder.Configuration["NumberValidationApiKey"];

        builder.Services.AddSingleton<GlobalService>();

        // Singleton is creating an instance from a class.
        builder.Services.AddSingleton(new NumberValidationApiService(NumberValidationApiKey)); // A global service

        // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.exchangeratesapi.io") });
        var ExchangeratesApiKey = builder.Configuration["ExchangeratesApiKey"];
        builder.Services.AddSingleton<ExchangeService>();
        builder.Services.AddSingleton(new ExchangeratesApiKeyService(ExchangeratesApiKey));

        await builder.Build().RunAsync();
    }
}
