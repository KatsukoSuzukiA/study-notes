using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{

    using System;
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public static class AppSettingsLoader
    {
        public static AppSettings Load()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json",optional: false,reloadOnChange: false).Build();

            var settings = new AppSettings();
            configuration.GetSection("Staff").Bind(settings.Staff);

            return settings;
        }
    }
}
