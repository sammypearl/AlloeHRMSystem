using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);
            // builder.HasKey(e => e.UserId);

            builder.Property(e => e.EmployeeId).HasMaxLength(30)
                .ValueGeneratedNever();
               

           // builder.Property(e => e.UserId).HasMaxLength(30);
            

            builder.Property(e => e.Firstname)
                .HasMaxLength(50);
                

            builder.Property(e => e.Lastname)
                .HasMaxLength(50);
           

            builder.Property(e => e.Phone).HasMaxLength(30);

            builder.Property(e => e.Email)
                .HasMaxLength(50);
            builder.Property(e => e.HomeAddress)
               .HasMaxLength(60);
            builder.Property(e => e.Department)
               .HasMaxLength(50);
            builder.Property(e => e.City)
               .HasMaxLength(50);

            builder.Property(e => e.Country)
               .HasMaxLength(50);

            builder.Property(e => e.JobTitle)
                .HasMaxLength(50);

            builder.Property(e => e.Rank).HasMaxLength(50);

            builder.Property(e => e.BloodType)
                .HasMaxLength(30);

            builder.Property(e => e.MaritalStatus)
                .HasMaxLength(50);


            builder.Property(e => e.DateOfBirth)
                .HasColumnType("date");

            builder.Property(e => e.Gender)
                .HasMaxLength(20);

            builder.Property(e => e.PhotoPath).HasMaxLength(255);
            builder.Property(e => e.Nationality)
               .HasMaxLength(50);

            builder.Property(e => e.HousePhone)
                .HasMaxLength(30);
            builder.Property(e => e.ContractType)
                   .HasMaxLength(50);

            builder.Property(e => e.JobLocation)
                .HasMaxLength(50);
            builder.Property(e => e.IsConfirmed);
            builder.Property(e => e.CreatedBy)
                .HasMaxLength(50);
            builder.Property(e => e.CreateDate)
               .HasColumnType("date");

            builder.Property(e => e.LastModifiedBy)
                .HasMaxLength(50);

            builder.Property(e => e.StartDate).HasColumnType("date");
            builder.Property(e => e.QuitDate).HasColumnType("date");

            builder.Property(e => e.IsLeavedJob);

            builder.Property(e => e.LeaveJobDate)
               .HasColumnType("date");

            builder.Property(e => e.LeaveJobReason)
                .HasMaxLength(500);

           
            builder.Property(e => e.LegalDayOff).HasMaxLength(20);

             // builder.HasOne(e => e.AppUser)
            //   .WithOne(e => e.Employee)
            //  .HasForeignKey<Employee>(e => e.UserId)
            //  .HasConstraintName("FK_AppUsers_Employees");

        }
    }
    
}
