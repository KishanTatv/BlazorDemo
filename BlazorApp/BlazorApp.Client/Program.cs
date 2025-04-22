using BlazorApp;
using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using BlazorBootstrap;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using SMS.DataAccess.Data.Implementations;
using SMS.DataAccess.Data.Implementations.Student;
using SMS.DataAccess.Data.Implementations.StudyMaterial;
using SMS.DataAccess.Data.Interfaces;
using SMS.DataAccess.Data.Interfaces.Student;
using SMS.DataAccess.Data.Interfaces.StudyMaterial;
using SMS.Shared.HttpManager.Delegator;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.JWTToken;
using SMS.Shared.Loader;
using SMS.Shared.Static.Constants;
using SMS.Shared.Static.Enum;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddLocalization();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

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
builder.Services.AddScoped<IStudyMaterial, StudyMaterial>();


//culture setup
var host = builder.Build();

string defaultCulture = LanguageEnum.Languages.English.GetDescription();

var js = host.Services.GetRequiredService<IJSRuntime>();
var result = await js.InvokeAsync<string>(JsStaticFun.blazorCultureGet);
var culture = CultureInfo.GetCultureInfo(result ?? defaultCulture);

if (result == null)
{
    await js.InvokeVoidAsync(JsStaticFun.blazorCultureSet, defaultCulture);
}

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

await host.RunAsync();
//await builder.Build().RunAsync();