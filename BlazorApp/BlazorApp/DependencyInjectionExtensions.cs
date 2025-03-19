

using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Blazored.LocalStorage;
using Blazored.Toast;
using Blazored.Toast.Services;
using SMS.DataAccess.Data.Implementations.Student;
using SMS.DataAccess.Data.Interfaces.Student;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.JWTToken;

namespace BlazorApp
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddBlazorBootstrap();
            services.AddServerSideBlazor();
            services.AddScoped<IToastService, ToastService>();

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAuth, Auth>();
            services.AddScoped<IStudent, Student>();

            services.AddHttpClient<IHttpClientManager, HttpClientManager>();
            services.AddBlazoredLocalStorage();
            services.AddBlazoredToast();

            return services;
        }
    }
}
