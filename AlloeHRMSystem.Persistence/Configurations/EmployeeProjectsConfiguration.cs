using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeProjectsConfiguration : IEntityTypeConfiguration<EmployeeProject>
   {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
           // builder.HasKey(e => e.EmployeeId);

            builder.HasKey(e => e.Name);

          //  builder.HasKey(e => e.Start);


            builder.Property(e => e.EmployeeId).HasMaxLength(30)
                .ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(60);

            builder.Property(e => e.Start)
                .HasColumnType("date");

            builder.Property(e => e.Finish)
                .HasColumnType("date");

            builder.Property(e => e.Completed)
                .HasMaxLength(60);

            builder.Property(e => e.JobPosition)
                .HasMaxLength(30);

            builder.Property(e => e.ProjectId).HasMaxLength(20);

            builder.Property(e => e.Notes).HasMaxLength(500)
                .HasColumnType("ntext");

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeProjects_Employees");
        }
    }
}
