using Microsoft.Extensions.Configuration;
using RestAPI.Framework.Utils;

namespace RestAPI.Framework.ConfigManager
{
    public static class ConfigManager
    {
        private static readonly IConfigurationRoot Configuration;
        private static readonly string[] configPath = ["Framework", "ConfigManager", "config.json"];
        public static string BaseUrl => Configuration["BaseUrl"];
        public static string[] UsersTestDataPath => Configuration.GetSection("Paths:UsersTestData").Get<string[]>();
        public static string[] PostsTestDataPath => Configuration.GetSection("Paths:PostsTestData").Get<string[]>();
        public static string[] CreatingPostTestDataPath => Configuration.GetSection("Paths:CreatingPostTestData").Get<string[]>();

        static ConfigManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(PathHelper.GetFullPath(configPath), optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

    }
}
