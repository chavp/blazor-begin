using BlazorAppChavp;
using BlazorAppChavp.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add the AppState class
builder.Services.AddScoped<PizzaSalesState>();
builder.Services.AddScoped<OrderState>();

builder.Services.AddSingleton<PizzaService>();

await builder.Build().RunAsync();