using System.IO;
using Microsoft.Extensions.Configuration;

namespace Demo2
{
    public class ConfigurationManager
    {
        public readonly static IConfiguration Configuration;

        static ConfigurationManager()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true).Build();
        }

    }
}