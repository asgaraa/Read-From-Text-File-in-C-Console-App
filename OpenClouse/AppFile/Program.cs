


//using AppFile.App;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System.Text;

//IHost _host = Host.CreateDefaultBuilder().ConfigureServices(
//services =>
//{
//    services.AddSingleton<IApplication, Application>();
//    services.AddDependencyLayer();

//})
//.Build();

//var app = _host.Services.GetRequiredService<IApplication>();

//app.Run();


using App.Helpers;
using AppFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_MyMall
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
}








