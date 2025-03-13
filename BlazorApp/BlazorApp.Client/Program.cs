using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IHttpClientManager, HttpClientManager>();

// Register API-based service
builder.Services.AddScoped<IAuth, Auth>();

await builder.Build().RunAsync();
