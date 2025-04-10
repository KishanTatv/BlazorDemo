using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Blazored.LocalStorage;
using Blazored.Toast;
using Blazored.Toast.Services;
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

namespace BlazorApp
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<LoaderService>();
            services.AddTransient<HttpDelegator>();

            // HttpClient with HttpDelegator
            services.AddHttpClient<IHttpClientManager, HttpClientManager>()
                    .AddHttpMessageHandler<HttpDelegator>();

            // Toast Service as Singleton
            services.AddSingleton<IToastService, ToastService>();

            // Application Services
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICommon, Common>();
            services.AddScoped<IAuth, Auth>();
            services.AddScoped<IStudent, Student>();
            services.AddScoped<IStudyMaterial, StudyMaterial>();

            // Blazor Bootstrap & Local Storage
            services.AddBlazorBootstrap();
            services.AddBlazoredLocalStorage();
            services.AddServerSideBlazor();
            services.AddBlazoredToast();

            return services;
        }
    }
}
