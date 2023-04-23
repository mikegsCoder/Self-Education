using AppHosting.Contracts;
using AppHosting.Services;
using AppHosting;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<App>();
            services.AddSingleton<MainWindow>();

            // add date services
            services.AddTransient(typeof(IBgDateService), typeof(BgDateService));
            services.AddTransient(typeof(IEnDateService), typeof(EnDateService));

            return services;
        }
    }
}
