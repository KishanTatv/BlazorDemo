using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Blazored.LocalStorage;
using Blazored.Toast;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.JWTToken;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IHttpClientManager, HttpClientManager>();
builder.Services.AddScoped<IToastService, ToastService>();
builder.Services.AddScoped<ITokenService, TokenService>();

// Register API-based service
builder.Services.AddScoped<IAuth, Auth>();
await builder.Build().RunAsync();
