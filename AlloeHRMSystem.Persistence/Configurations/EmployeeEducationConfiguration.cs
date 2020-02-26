using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeEducationConfiguration : IEntityTypeConfiguration<EmployeeEducation>
   {
        public void Configure(EntityTypeBuilder<EmployeeEducation> builder)
        {
            builder.HasKey(e => e.DegreeId);

            builder.Property(e => e.EmployeeId)
                   .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.Department).HasMaxLength(50);

            builder.Property(e => e.DegreeId)
                .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.Degree)
               .HasMaxLength(50);

            builder.Property(e => e.Institution)
                .HasMaxLength(50);

            builder.Property(e => e.StillStudying)
                .HasMaxLength(50);

            builder.Property(e => e.Notes)
                .HasColumnType("ntext").HasMaxLength(500);

            builder.Property(e => e.Thesis)
                .HasColumnType("ntext").HasMaxLength(500);

            builder.Property(e => e.EntranceDate).HasColumnType("date");

            builder.Property(e => e.GraduationDate)
                .HasColumnType("date");

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeEducations)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeEducations_Employees");
        }
    }
}
