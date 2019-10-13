using IdealWay.Application;
using IdealWay.Domain.Entities;
using IdealWay.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace IdealWay.Persistence
{
    public class DevSalaryDbContext: DbContext, IDevSalaryDbContext
    {
        public DevSalaryDbContext(DbContextOptions<DevSalaryDbContext> options)
            : base(options)
        {
            
        }


        public DbSet<Developer> Developers { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public IQueryable<T> GetAllQuery<T>() where T: class
        {
            return this.Set<T>().AsQueryable();
        }

        public IQueryable<T> GetAllNoCachingQuery<T>() where T : class
        {
            return this.Set<T>().AsNoTracking().AsQueryable();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DevSalaryDbContext).Assembly);
            SeedDataHelper.SeedAllData(builder);
        }
    }
}
