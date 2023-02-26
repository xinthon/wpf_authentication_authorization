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

namespace wpf_authentication_authorization.Core.HostBuilders
{
    public static class AddIdentityUserHostbBuilderExtensions
    {
        public static IHostBuilder AddIdentityUser(this IHostBuilder hostBuilder)
        {
            return hostBuilder;
        }
    }
}
