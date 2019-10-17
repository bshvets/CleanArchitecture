using QuickWay.Application;
using QuickWay.Domain.Entities;
using QuickWay.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QuickWay.Persistence
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

        public void AddEntity<T>(T entity) where T : class
        {
            this.Set<T>().Add(entity);
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
