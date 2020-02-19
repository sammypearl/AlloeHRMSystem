using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
    public class EmployeeTrainingConfiguration : IEntityTypeConfiguration<EmployeeTraining>
    {
        public void Configure(EntityTypeBuilder<EmployeeTraining> builder)
        {
            builder.HasKey(e => e.Name );

            builder.Property(e => e.EmployeeId).HasMaxLength(30)
                .ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(50);

            builder.Property(e => e.Location).HasMaxLength(50);

            builder.Property(e => e.Duration)
                .HasMaxLength(50);

            builder.Property(e => e.Provider)
                .HasMaxLength(60);

            builder.Property(e => e.Start)
                .HasColumnType("date");

            builder.Property(e => e.Finish)
                .HasColumnType("date");

            builder.Property(e => e.Notes)
                .HasMaxLength(500);


            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeTrainings)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTrainings_Employees");



        }
    }
}
