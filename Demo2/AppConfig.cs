using Microsoft.Extensions.Configuration;

namespace Demo2
{
    public class AppConfig
    {
        public static string MysqlConnection { get; } =
            ConfigurationManager.Configuration.GetConnectionString("MySql");
    }
}