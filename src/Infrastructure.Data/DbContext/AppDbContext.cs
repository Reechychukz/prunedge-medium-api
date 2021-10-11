﻿using Microsoft.EntityFrameworkCore;

namespace Infrastucture.Data.DbContext
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        /// <summary>
        /// Dbcontext comment
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
        }
    }
}
