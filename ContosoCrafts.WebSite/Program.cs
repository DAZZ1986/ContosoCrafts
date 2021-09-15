using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }




    /*
    What is ASP.NET? [1 of 13]
    ASP.NET - Making an ASP.NET Core Website [2 of 13]
    ASP.NET - Adding Data to an ASP.NET Core Website [3 of 13]
    ASP.NET - Adding a Service to an ASP.NET Core Website [4 of 13]
    ASP.NET - Data in a Razor Page [5 of 13]
    ASP.NET - Styling a Razor Page [6 of 13]
    ASP.NET - Making a Simple API [7 of 13]
    ASP.NET - Enhancing your Web API: Part 1 [8 of 13]
    ASP.NET - Enhancing your Web API: Part 2 [9 of 13]
    ASP.NET - Introducing Blazor: Razor Components [10 of 13]
    ASP.NET - Introducing Blazor: Structure and Debugging [11 of 13]
    ASP.NET - Introducing Blazor: Interactivity [12 of 13]
    ASP.NET - Publishing an Website to Azure [13 of 13]
    */
}
