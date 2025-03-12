

using BlazorApp.Data.Implementations.Auth;
using BlazorApp.Data.Interfaces.Auth;

namespace BlazorApp
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IAuth, Auth>();

            services.AddHttpClient();

            return services;
        }
    }
}
