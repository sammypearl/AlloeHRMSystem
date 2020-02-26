using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeCertificateConfiguration : IEntityTypeConfiguration<EmployeeCertificate>
   {
        public void Configure(EntityTypeBuilder<EmployeeCertificate> builder)
        {
            builder.HasKey(e => e.Name);

            builder.Property(e => e.EmployeeId)
                .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(50);

            builder.Property(e => e.Provider).HasMaxLength(50);

            builder.Property(e => e.Date).HasColumnType("date");

            builder.Property(e => e.Notes)
                .HasColumnType("ntext").HasMaxLength(500);

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeCertificates)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeCertificates_Employees");

        }
    }
}
