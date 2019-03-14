using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace NetCoreTuto2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog(
                    (hostingContext, loggerConfiguration) =>
                        loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration)
                 //.Enrich.WithExceptionDetails() //TODO: add an Exceptions enricher https://github.com/RehanSaeed/Serilog.Exceptions
                 //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning // note: we can also use a LoggingLevelSwitch here or in the configuration file in order to change this value with a remote api call
                 );
    }
}
