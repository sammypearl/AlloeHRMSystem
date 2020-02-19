using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
    public class EmployeeQuitConfiguration : IEntityTypeConfiguration<EmployeeQuit>
    {
        public void Configure(EntityTypeBuilder<EmployeeQuit> builder)
        {
            builder.HasKey(e => e.ApproverId);

            builder.Property(e => e.EmployeeId).HasMaxLength(30)
                .ValueGeneratedNever();

            builder.Property(e => e.ApproverId)
               .HasMaxLength(20).ValueGeneratedNever();

            builder.Property(e => e.ProcessBegin).HasColumnType("date");

            builder.Property(e => e.ProcessEnd)
                .HasColumnType("date");

            builder.Property(e => e.CHRAdvance)
                .HasMaxLength(60);

            builder.Property(e => e.TrainingCancel)
                .HasMaxLength(50);

            builder.Property(e => e.HealthInsurance)
                .HasMaxLength(50);

            builder.Property(e => e.CHRNotes)
                .HasColumnType("ntext").HasMaxLength(500);

            builder.Property(e => e.CompanyIdCard).HasMaxLength(20);


            builder.Property(e => e.PC).HasMaxLength(50);

            builder.Property(e => e.Monitor).HasMaxLength(50);

            builder.Property(e => e.PhoneHeadSet).HasMaxLength(30);
               

            builder.Property(e => e.CioNotes).HasColumnType("ntext")
                .HasMaxLength(500);

            builder.Property(e => e.CreditCard)
                .HasMaxLength(30);

            builder.Property(e => e.GSMCard).HasMaxLength(50);

            builder.Property(e => e.CompanyVehicle)
                .HasMaxLength(50);

            builder.Property(e => e.VehicleEntryStamp)
                .HasMaxLength(60);

            builder.Property(e => e.BookKeepingAdvance).HasMaxLength(30);

            builder.Property(e => e.BANotes).HasColumnType("ntext")
                .HasMaxLength(500);

            builder.Property(e => e.Multinet).HasMaxLength(50);
                

            builder.Property(e => e.Quit);


            builder.Property(e => e.QuitDate).HasColumnType("date");

            builder.Property(e => e.QuitReason)
               .HasColumnType("ntext").HasMaxLength(500);

            builder.Property(e => e.MailSent).HasMaxLength(50);

            builder.HasOne(e => e.Employee)
                .WithOne(e => e.EmployeeQuit)
                
                .HasForeignKey<EmployeeQuit>(e => e.EmployeeId)
                
                .HasConstraintName("FK_EmployeeQuits_Employees");

            // modelBuilder.Entity<Author>()
            //.HasOptional(a => a.Biography)
            //.WithRequired(ab => ab.Author);

            // modelBuilder.Entity<City>()
                
            //.HasOne(e => e.CityInformation)
            //.WithOne(e => e.City)
            //.HasForeignKey<City>(e => e.CityInformationId);

        }
    }
}
