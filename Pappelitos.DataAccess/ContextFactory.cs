using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Pappelitos.DataAccess
{

    public class ContextFactory : IDesignTimeDbContextFactory<PappelitosContext>
    {

        public enum ContextType
        {
            MEMORY, SQL
        }
        public PappelitosContext CreateDbContext(string[] args)
        {
            return GetNewContext();

        }

        public static PappelitosContext GetNewContext(ContextType type = ContextType.SQL)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<PappelitosContext>();

            return new PappelitosContext(builder.Options);
        } 
    }
}