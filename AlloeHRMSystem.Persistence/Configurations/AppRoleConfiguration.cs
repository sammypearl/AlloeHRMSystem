using AlloeHRMSystem.Domain.IdentityEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlloeHRMSystem.Persistence.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // builder.HasKey(e => e.Id);
            builder.Property(e => e.Description).HasColumnType("ntext");
               
            builder.Property(e => e.CreatedBy)
                .HasMaxLength(50);

            builder.Property(e => e.CreateDate)
                .HasColumnType("date");

            builder.Property(e => e.ModifiedBy)
                .HasMaxLength(50);
            builder.Property(e => e.ModifiedDate).HasColumnType("date")
                ;

            //builder.HasOne(e => e.AppUser)
            //     .WithMany(e => e.AppRoles)
            //     .HasForeignKey(e => e.Id)
            //     .OnDelete(DeleteBehavior.ClientSetNull)
            //     .HasConstraintName("FK_AppRoles_AppUsers");

        }
    }
}
