using App.Repository;
using App.Services;
using App.Services.Interfaces;
using AppFile.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace AppFile.App
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyLayer(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository), typeof(FileRepository));
            services.AddScoped<IControllerFactory, ControllerFactory>();
            services.AddScoped<ILog, AppLogger>();
        

            return services;
        }
    }
}
