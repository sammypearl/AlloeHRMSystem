using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AlloeHRMSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlloeHRMSystem.Persistence.Configurations
{
   public class EmployeeAttachmentConfiguration : IEntityTypeConfiguration<EmployeeAttachment>
   {
        public void Configure(EntityTypeBuilder<EmployeeAttachment> builder)
        {
            
            builder.HasKey(e => e.FileName );

            builder.Property(e => e.FileName).HasMaxLength(50)
               .HasColumnType("nvarchar");

            builder.Property(e => e.EmployeeId)
                .HasMaxLength(30).ValueGeneratedNever();

            builder.Property(e => e.FileId).HasMaxLength(20);
                
            builder.Property(e => e.URLOnly)
                .HasMaxLength(50);

            builder.Property(e => e.Notes).HasColumnType("ntext")
                .HasMaxLength(500);

            builder.Property(e => e.FileSize)
                .HasMaxLength(20);

            builder.Property(e => e.Type)
                .HasMaxLength(30);

            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeAttachments)                
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeAttachments_Employees");


        }
    }
}
