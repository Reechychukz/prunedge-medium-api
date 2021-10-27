using Domain.Entities;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastucture.Data.DbContext
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        /// <summary>
        /// Dbcontextm comment
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
        }

        
    }
}
