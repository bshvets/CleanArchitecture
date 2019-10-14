using IdealWay.Domain.Entities;
using IdealWay.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Persistence.Configuration
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.ToTable("Developer");

            builder.HasKey(e => e.DeveloperId);

            builder.Property(e => e.DeveloperId)
                .IsRequired();

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.YearsOfExperience)
                .IsRequired();

            builder.Property(e => e.Level)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<AbilitonLevel>())
                .HasMaxLength(20);

            builder.Property(e => e.Gender)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<Gender>())
                .HasMaxLength(20);

            builder.HasOne(p => p.PrimaryLanguage)
                .WithMany(d => d.Developers)
                .HasForeignKey(a => a.PrimaryLanguageId);
        }
    }
}
