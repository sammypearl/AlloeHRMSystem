using AlloeHRMSystem.Domain.IdentityEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace AlloeHRMSystem.Persistence.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
             builder.HasKey(e => e.UserId);
            
            // builder.HasKey(e => e.Username);
            //builder.Property(e => e.EmployeeId)
            //    .HasMaxLength(30);

            builder.Property(e => e.UserId)
               .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.FirstName) 
                .HasMaxLength(50);


            builder.Property(e => e.LastName)
                .HasMaxLength(50);
           
            builder.Property(e => e.Title)
                .HasMaxLength(50);

            builder.Property(e => e.MobileNo).HasMaxLength(30);

            builder.Property(e => e.Language)
                .HasMaxLength(50);

            builder.Property(e => e.Company)
               .HasMaxLength(50);

            builder.Property(e => e.Department)
               .HasMaxLength(50);

            builder.Property(e => e.JobTitle).HasMaxLength(50);

            builder.Property(e => e.HomePhone)
                .HasMaxLength(30);
            builder.Property(e => e.CreatedBy)
               .HasMaxLength(50);

            builder.Property(e => e.CreateDate)
                .HasColumnType("date");

            builder.Property(e => e.ModifyBy)
                .HasMaxLength(50);

            builder.Property(e => e.LastPasswordUpdate).HasColumnType("date");

            builder.Property(e => e.PasswordExpirationEnable);

            builder.Property(e => e.CanMakeCall);

            //builder.HasOne(e => e.Employee)
            //   .WithOne(e => e.AppUser)
            //   .HasForeignKey<AppUser>(e => e.EmployeeId)

            //   .HasConstraintName("FK_AppUsers_Employees");
        }
    }
}
