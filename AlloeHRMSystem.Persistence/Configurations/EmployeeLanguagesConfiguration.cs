using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeLanguagesConfiguration : IEntityTypeConfiguration<EmployeeLanguage>
   {
        public void Configure(EntityTypeBuilder<EmployeeLanguage> builder)
        {

            builder.HasKey(e => e.Language );

            builder.Property(e => e.EmployeeId)
                   .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.Language).HasMaxLength(50);

            builder.Property(e => e.WrittenLevel)
                .HasMaxLength(50);

            builder.Property(e => e.SpeakingLevel)
                .HasMaxLength(50);

            builder.Property(e => e.NativeLang)
                .HasMaxLength(50);

            builder.Property(e => e.LanguageId).HasMaxLength(25);

            builder.Property(e => e.Notes)
             .HasColumnType("ntext").HasMaxLength(500);

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeLanguages)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLanguages_Employees");
        }
    }

}

