using IdealWay.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Persistence.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answer");

            builder.HasKey(p => p.AnswerId);

            builder.Property(p => p.DeveloperId)
                .IsRequired();

            builder.Property(p => p.YearSalary)
                .IsRequired();

            builder.Property(p => p.Satisfied)
                .IsRequired()
                .HasDefaultValue(true);
        }
    }
}
