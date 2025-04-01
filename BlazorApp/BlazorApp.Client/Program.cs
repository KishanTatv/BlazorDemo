using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using BlazorBootstrap;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SMS.DataAccess.Data.Implementations;
using SMS.DataAccess.Data.Implementations.Student;
using SMS.DataAccess.Data.Interfaces;
using SMS.DataAccess.Data.Interfaces.Student;
using SMS.Shared.HttpManager.Delegator;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.JWTToken;
using SMS.Shared.Loader;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddSingleton<PreloadService>();
builder.Services.AddSingleton(new LoaderService());


//HttpDelegator
builder.Services.AddTransient<HttpDelegator>();
builder.Services.AddScoped(sp =>
{
    var httpClient = new HttpClient(new HttpClientHandler());
    var delegator = sp.GetRequiredService<HttpDelegator>();
    delegator.InnerHandler = new HttpClientHandler();

    return new HttpClient(delegator)
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    };
});
builder.Services.AddScoped<IHttpClientManager, HttpClientManager>();

builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<ICommon, Common>();
builder.Services.AddScoped<IAuth, Auth>();
builder.Services.AddScoped<IStudent, Student>();

await builder.Build().RunAsync();