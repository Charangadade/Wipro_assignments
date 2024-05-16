using Microsoft.Extensions.Configuration;
using System.IO;



public class ConfigurationReader
{
    private IConfigurationRoot configuration;



   public ConfigurationReader()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);



       configuration = builder.Build();
    }



   public WebDriverOptions GetWebDriverOptions()
    {
        var options = new WebDriverOptions();
        configuration.GetSection("WebDriverOptions").Bind(options);
        return options;
    }
}

