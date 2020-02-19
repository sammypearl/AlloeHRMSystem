using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
    public class EmployeeTechnicalSkillsConfiguration : IEntityTypeConfiguration<EmployeeTechnicalSkill>
    {
        public void Configure(EntityTypeBuilder<EmployeeTechnicalSkill> builder)
        {
            builder.HasKey(e => e.Name );

            builder.Property(e => e.EmployeeId).HasMaxLength(30)
                .ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(50);

            builder.Property(e => e.Level).HasMaxLength(30);

            builder.Property(e => e.Notes)
                .HasColumnType("ntext").HasMaxLength(500);

            builder.Property(e => e.SkillId).HasMaxLength(30);

            builder.Property(e => e.LevelId).HasMaxLength(30);


            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeTechnicalSkills)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTechnicalSkills_Employees");

        }
    }
}
