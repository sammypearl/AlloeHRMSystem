using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeEmergencyCallsConfiguration : IEntityTypeConfiguration<EmployeeEmergencyCall>
   {
        public void Configure(EntityTypeBuilder<EmployeeEmergencyCall> builder)
        {
            builder.HasKey(e => e.Name);

            builder.Property(e => e.EmployeeId)
                   .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(60);

            builder.Property(e => e.SurName).HasMaxLength(50);

            builder.Property(e => e.RelationTo)
                .HasMaxLength(50);

            builder.Property(e => e.Phone)
                .HasMaxLength(30);

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeEmergencyCalls)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                
                .HasConstraintName("FK_EmployeeEmergencyCalls_Employees");


        }
    }
}
