using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Infrastucture.Data.DbContext;
using Microsoft.AspNetCore.Mvc;

namespace API.Installers
{
    public class DbInstaller : IInstaller
    {
        public static readonly ILoggerFactory contextLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public void InstallerServices( IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options =>
                options
                .UseLoggerFactory(contextLoggerFactory)
                .UseSqlServer(defaultConnection));
        }
    }
}
