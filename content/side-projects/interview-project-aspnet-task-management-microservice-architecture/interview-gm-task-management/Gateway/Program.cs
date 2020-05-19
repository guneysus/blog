﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;

namespace Gateway
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateWebHostBuilder(args)
      .ConfigureServices(s =>
      {
        s.AddOcelot();
      })
      .ConfigureLogging((hostingContext, logging) =>
      {
              //add your logging
            })
      .UseIISIntegration()
      .Configure(app =>
      {
        app.UseOcelot().Wait();
      })
      .Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((host, config) => {
                config.AddJsonFile("ocelot.json");
            })
            .UseStartup<Startup>();
  }
}