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
                connectionString = "http://192.168.3.103:8091/api/";
            }
            return connectionString;
        }

    }

}
