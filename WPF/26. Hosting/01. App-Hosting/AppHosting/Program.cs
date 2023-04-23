using AppHosting.Contracts;
using AppHosting.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AppHosting
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            // create host
            var host = Host.CreateDefaultBuilder()
                 // add services
                .ConfigureServices(services =>
                {
                    services.AddApplicationServices();
                    
                    //services.AddSingleton<App>();
                    //services.AddSingleton<MainWindow>();

                    //// add date services
                    //services.AddTransient<IBgDateService, BgDateService>();
                    //services.AddTransient<IEnDateService, EnDateService>();
                })
                .Build();

            // get service - object of class App
            var app = host.Services.GetService<App>();

            // run application
            app?.Run();
        }
    }
}
