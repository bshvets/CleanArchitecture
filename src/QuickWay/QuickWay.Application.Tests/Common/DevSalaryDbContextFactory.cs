using QuickWay.Domain.Entities;
using QuickWay.Domain.Enums;
using QuickWay.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Application.Tests.Common
{
    public class DevSalaryDbContextFactory
    {
        public static IDevSalaryDbContext Create()
        {
            var options = new DbContextOptionsBuilder<DevSalaryDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new DevSalaryDbContext(options);

            context.Database.EnsureCreated();

            //SeedDataHelper fills all test data
            
            context.SaveChanges();

            return context;
        }

        public static void Destroy(IDevSalaryDbContext context)
        {
            (context as DevSalaryDbContext).Database.EnsureDeleted();

            (context as DevSalaryDbContext).Dispose();
        }
    }
}
