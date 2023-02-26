using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf_authentication_authorization.Core.Data;
using wpf_authentication_authorization.Core.Models;
using wpf_authentication_authorization.Core.Services.Interfaces;

namespace wpf_authentication_authorization.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DbContextFactory _contextFactory;

        public AuthenticationService(DbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            using (var _dbContext = _contextFactory.CreateDbContext())
            {
                var user = await _dbContext.Users.Where(u => u.UserName == username && u.Password == password).FirstOrDefaultAsync();

                if (user == null)
                {
                    throw new Exception("Please provide a valid cedential");
                }

                return (User)user;
            }
        }
    }
}
