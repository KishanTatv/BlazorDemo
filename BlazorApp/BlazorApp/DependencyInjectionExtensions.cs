

using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Blazored.LocalStorage;
using Blazored.Toast;
using Blazored.Toast.Services;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.JWTToken;

namespace BlazorApp
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IToastService, ToastService>();

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAuth, Auth>();

            services.AddHttpClient<IHttpClientManager, HttpClientManager>();
            services.AddBlazoredLocalStorage();
            services.AddBlazorBootstrap();
            services.AddBlazoredToast();

            return services;
        }
    }
}
