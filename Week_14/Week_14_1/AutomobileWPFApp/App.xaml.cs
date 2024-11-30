using AutomobileLibrary.Repository;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AutomobileWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            // Configure dependency injection
            ServiceCollection services = new ServiceCollection();
            ConfigurationServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private static void ConfigurationServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(ICarRepository), typeof(CarRepository));
            services.AddSingleton<WindowCarManagement>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var windowCarManagement = serviceProvider.GetService<WindowCarManagement>();
            windowCarManagement!.Show();
        }
    }

}
