using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace UBS_Test_Automation.Framework.Setup
{
    public class ConfigReader
    {
        public IConfiguration Configuration { get; set; }
        public Config Config { get; }

        public ConfigReader(/*IHostingEnvironment env*/)
        {
            var builder = new ConfigurationBuilder()
                //.SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            var configSection = Configuration.GetSection("Config");
            Config = configSection.Get<Config>();
        }
    }
}
