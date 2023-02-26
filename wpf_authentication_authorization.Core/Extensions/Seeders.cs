using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_authentication_authorization.Core.Models;

namespace wpf_authentication_authorization.Core.Extensions
{
    internal static class Seeders
    {
        internal static ModelBuilder UserSeeder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new
            {
                Id = 1,
                UserName = "Admin",
                Password = "P@ssw0rd",
                Email = "admin@example.com"
            });

            return modelBuilder;
        }
    }
}
