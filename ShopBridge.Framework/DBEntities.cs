using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ShopBridge.Framework.StorageClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Framework
{
    public class DBEntities : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly IConfiguration _config;

        public DBEntities(ILoggerFactory loggerFactory, IConfiguration config)
        {
            _loggerFactory = loggerFactory;
            _config = config;
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["SqlServerConnectionString"])
                           .UseLoggerFactory(this._loggerFactory);
#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif
        }
    }
}
