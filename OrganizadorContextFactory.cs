using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContextFactory : IDesignTimeDbContextFactory<OrganizadorContext>
    {
        public OrganizadorContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<OrganizadorContext>();
            var connectionString = configuration.GetConnectionString("ConexaoPadrao");

            builder.UseSqlServer(connectionString);

            return new OrganizadorContext(builder.Options);
        }
    }
}