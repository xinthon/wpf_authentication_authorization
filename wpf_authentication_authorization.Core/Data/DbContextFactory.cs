using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_authentication_authorization.Core.HostBuilders;

namespace wpf_authentication_authorization.Core.Data
{
    public class DbContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;
        public DbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        public AppDataContext CreateDbContext()
        {
            DbContextOptionsBuilder<AppDataContext> options = new DbContextOptionsBuilder<AppDataContext>();
            _configureDbContext(options);
            return new AppDataContext(options.Options);
        }
    }
}
