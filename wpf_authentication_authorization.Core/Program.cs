using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System;
using wpf_authentication_authorization.Core.Models;

namespace wpf_authentication_authorization.Core
{
    public  class Program
    {
        public static bool IsLoading { get; set; } = false;
        public static User Auth { get; set; }
        public static IHost hostBuilder { get; set; }
    }
}
