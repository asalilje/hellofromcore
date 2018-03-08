using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloFromCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            BuildWebHost(args).Run();
            Console.WriteLine("Started");
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:3001")
                .Build();
    }
}
