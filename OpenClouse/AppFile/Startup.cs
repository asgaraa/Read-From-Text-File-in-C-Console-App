using App.Helpers;
using App.Repository;
using App.Services;
using AppFile.App;
using AppFile.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFile
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Start.Started();
        }

        public IConfiguration Configuration { get; }

   
        public void ConfigureServices(IServiceCollection services)
        {
          

            services.AddControllers();
         
            services.AddDependencyLayer();
         
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            



            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }
    }
}