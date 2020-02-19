using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AlloeHRMSystem.UI.Models;
using AlloeHRMSystem.Domain.IdentityEntities;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AlloeHRMSystem.Persistence
{
    public class AlloeContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AlloeContext(DbContextOptions<AlloeContext> options) : base(options)
        {
            
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //   // modelBuilder.Seed();

        //    //foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
        //    //    .SelectMany(e => e.GetForeignKeys()))
        //    //{
        //    //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        //    //}
        //}

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
   

        public DbSet<EmployeeAttachment> EmployeeAttachments { get; set; }

        public DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }

     
        public DbSet<EmployeeEmergencyCall> EmployeeEmergencyCalls { get; set; }

        public DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public DbSet<EmployeeQuit> EmployeeQuits { get; set; }

        public DbSet<EmployeeTechnicalSkill> EmployeeTechnicalSkills { get; set; }

        public DbSet<EmployeeTraining> EmployeeTrainings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlloeContext).Assembly);
           
           // modelBuilder.ApplyConfiguration();

            //modelBuilder.Entity<AppUser>().ToTable("AppUser");
            //modelBuilder.Entity<AppRole>().ToTable("AppRole");
            //modelBuilder.Entity<Employee>().ToTable("Employee");
            //modelBuilder.Entity<EmployeeAttachment>().ToTable("EmployeeAttachment");
            //modelBuilder.Entity<EmployeeCertificate>().ToTable("EmployeeCertificate");
            //modelBuilder.Entity<EmployeeEducation>().ToTable("EmployeeEducation");
            //modelBuilder.Entity<EmployeeEmergencyCall>().ToTable("EmployeeEmergencyCall");
            //modelBuilder.Entity<EmployeeLanguage>().ToTable("EmployeeLanguage");
            //modelBuilder.Entity<EmployeeProject>().ToTable("EmployeeProject");
            //modelBuilder.Entity<EmployeeQuit>().ToTable("EmployeeQuit");
            //modelBuilder.Entity<EmployeeTechnicalSkill>().ToTable("EmployeeTechnicalSkill");
            //modelBuilder.Entity<EmployeeTraining>().ToTable("EmployeeTraining");

        }

    }
}
