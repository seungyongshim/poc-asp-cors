using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using fe;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => 
{
    var http = new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5187"),
        DefaultRequestHeaders =
        {
            
        }
    };

    http.DefaultRequestHeaders.Add("x-api-key", "111");

    return http;
});

await builder.Build().RunAsync();
