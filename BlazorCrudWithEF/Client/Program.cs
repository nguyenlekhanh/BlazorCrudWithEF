global using BlazorCrudWithEF.Client.Services.SuperHeroService;
global using BlazorCrudWithEF.Shared;
using BlazorCrudWithEF.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ISuperHeroService, SuperHeroService>();


await builder.Build().RunAsync();
