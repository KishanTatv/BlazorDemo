using Microsoft.Extensions.Configuration;

namespace SMS.DataAccess.Data
{
    public class AppSettingsConfig
    {
        public static string GetConnectionString(IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("ApiBaseUrl");
            if (connectionString == null)
            {
                connectionString = "https://localhost:7057/api/";
            }
            return connectionString;
        }

    }

}
