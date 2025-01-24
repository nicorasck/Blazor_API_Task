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
        builder.Services.AddSingleton(new NumberValidationApiService(NumberValidationApiKey));
        builder.Services.AddSingleton<GlobalService>();


        await builder.Build().RunAsync();
    }
}
