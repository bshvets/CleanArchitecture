using QuickWay.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWay.Persistence.Configuration
{
    public class SurveyAnswerConfiguration : IEntityTypeConfiguration<SurveyAnswer>
    {
        public void Configure(EntityTypeBuilder<SurveyAnswer> builder)
        {
            builder.ToTable("SurveyAnswer");

            builder.HasKey(p => p.AnswerId);

            builder.Property(p => p.DeveloperId)
                .IsRequired();

            builder.Property(p => p.YearSalary)
                .IsRequired();

            builder.Property(p => p.Satisfied)
                .IsRequired()
                .HasDefaultValue(true);

            builder.HasOne(p => p.Developer)
                .WithMany(d => d.Answers)
                .HasForeignKey(a => a.DeveloperId);
        }
    }
}
