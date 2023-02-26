using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using wpf_authentication_authorization.Core.Services.Interfaces;
using wpf_authentication_authorization.Core.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wpf_authentication_authorization.Core.HostBuilders
{
    public static class AddServicesHostBuilderExtensions
    {
        public static IHostBuilder AddServices(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<IAuthenticationService, AuthenticationService>();
            });

            return hostBuilder;
        }
    }
}
