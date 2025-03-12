

using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;
using SMS.Shared.HttpManager.Implementation;
using SMS.Shared.HttpManager.Interface;

namespace BlazorApp
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IAuth, Auth>();

            services.AddHttpClient<IHttpClientManager, HttpClientManager>();
            //services.AddHttpClient();

            return services;
        }
    }
}
