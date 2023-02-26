using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_authentication_authorization.Core.Data;
using wpf_authentication_authorization.Core.Services.Interfaces;
using wpf_authentication_authorization.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace wpf_authentication_authorization.Core.HostBuilders
{
    public static class AddDbContextHostBuilderExtenstions
    {
        public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context , services) =>
            {
                string connectionString = @"Data Source=DESKTOP-FAVHP4I\SQLEXPRESS;Initial Catalog=wpf_authentication_authorization;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                Action<DbContextOptionsBuilder> configureDbContext = (options) => options.UseSqlServer(connectionString);

                services.AddDbContext<AppDataContext>(configureDbContext);
                services.AddSingleton<DbContextFactory>(new DbContextFactory(configureDbContext));
            });
            return hostBuilder;
        }
    }
}
