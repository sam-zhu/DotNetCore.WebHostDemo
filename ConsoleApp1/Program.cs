using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NLog.Web;
using System;

namespace DotNetCore.WebHostDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }


        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging((hostingContext, builder) =>
                {
                    hostingContext.HostingEnvironment.ConfigureNLog("nlog.config");
                })
                .UseNLog()
                .Build();
    }



}
