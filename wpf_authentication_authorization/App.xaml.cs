using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;
using System.Windows;
using wpf_authentication_authorization.Core.Data;
using wpf_authentication_authorization.Core.HostBuilders;

namespace wpf_authentication_authorization
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        public App()
        {
            Core.Program.hostBuilder = CreateHostBuilder().Build();
        }

        private static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);

            hostBuilder.ConfigureServices((context, services) =>
            {

            });

            hostBuilder
                .AddServices()
                .AddDbContext();

            return hostBuilder;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var contextFactory = Core.Program.hostBuilder.Services.GetRequiredService<DbContextFactory>();
            using (var context = contextFactory.CreateDbContext())
            {
                context.Database.Migrate();
            }

            Core.Program.hostBuilder.StartAsync();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await Core.Program.hostBuilder.StopAsync();
            Core.Program.hostBuilder.Dispose();
            base.OnExit(e);
        }
    }
}
