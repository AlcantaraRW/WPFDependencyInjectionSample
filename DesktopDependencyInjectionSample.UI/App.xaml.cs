using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace DesktopDependencyInjectionSample.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var serviceProvider = CreateServiceProvider();

            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private IServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddScoped<IGreeter, Greeter>();
            services.AddSingleton<MainWindow>();

            return services.BuildServiceProvider();
        }
    }
}
