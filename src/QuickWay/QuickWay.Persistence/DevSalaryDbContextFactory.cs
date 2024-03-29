﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Persistence
{
    class DevSalaryDbContextFactory : IDesignTimeDbContextFactory<DevSalaryDbContext>
    {
        public DevSalaryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DevSalaryDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=SurveyMain;Trusted_Connection=True");
    
            return new DevSalaryDbContext(optionsBuilder.Options);
        }
    }
}
