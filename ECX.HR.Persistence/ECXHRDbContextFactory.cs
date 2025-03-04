﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECX.HR.Persistence
{
    public static partial class PersistenceServiceRegistrtion
    {
        public class ECXHRDbContextFactory 
            : IDesignTimeDbContextFactory<ECXHRDbContext>
        {
            public ECXHRDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                var builder = new DbContextOptionsBuilder<ECXHRDbContext>();
                var connectionString = configuration.GetConnectionString("ECXHRConnectionString");
                builder.UseSqlServer(connectionString);
                return new ECXHRDbContext(builder.Options);
            }
        }

    }
}
