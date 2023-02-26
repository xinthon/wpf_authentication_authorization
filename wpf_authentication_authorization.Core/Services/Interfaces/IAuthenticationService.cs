using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_authentication_authorization.Core.Models;

namespace wpf_authentication_authorization.Core.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<User> LoginAsync(string username,string password);
    }
}
