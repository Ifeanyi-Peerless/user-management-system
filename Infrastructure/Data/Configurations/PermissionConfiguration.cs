using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PermissionConfiguration : BaseEntityConfiguration<Permission>, IEntityTypeConfiguration<Permission>
    {
        public override void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.Property(t => t.PermissionId)
            .HasColumnName("PERMISSION_ID");

            builder.Property(t => t.Name)
            .HasColumnName("NAME");

                
            builder.Property(t => t.ApprovedBy)
                .HasColumnType("varchar(100)")
                .HasColumnName("APPROVED_BY");
            builder
                .Property(t => t.CreatedBy)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .HasColumnName("CREATED_BY");
            builder
                .Property(t => t.HashValue)
                .HasColumnType("varchar(500)")
                .HasMaxLength(500)
                .HasColumnName("HASH_VALUE");
            builder
                .Property(t => t.LastModifiedBy)
                .HasColumnType("varchar(100)")
                .HasColumnName("LAST_MODIFIED_BY")
                .HasMaxLength(100);
            builder
                .Property(t => t.DeletedBy)
                .HasColumnType("varchar(100)")
                .HasColumnName("DELETED_BY")
                .HasMaxLength(100);
            builder
                .Property(t => t.Status)
                .HasColumnType("bool")
                .HasColumnName("STATUS")
                .HasMaxLength(50);
            builder.Property(t => t.IsDeleted).HasColumnName("IS_DELETED");
            builder
                .Property(t => t.DeletedFlag)
                .HasColumnType("bool")
                .HasColumnName("DELETED_FLAG");
            builder
                .Property(t => t.DateApproved)
                .HasColumnType("date")
                .HasColumnName("DATE_APPROVED");
            builder
                .Property(t => t.DateCreated)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("DATE_CREATED");
            builder
                .Property(t => t.LastModifiedDate)
                .HasColumnType("date")
                .HasColumnName("LAST_MODIFIED_DATE")
                .IsRequired(false);
            builder
                .Property(t => t.DateDeleted)
                .HasColumnType("date")
                .HasColumnName("DATE_DELETED")
                .IsRequired(false);
            builder
                .Property(t => t.LastModifiedTime)
                .HasColumnName("LAST_MODIFIED_TIME")
                .IsRequired(false);
            builder.Property(t => t.TimeApproved).HasColumnName("TIME_APPROVED").IsRequired(false);
            builder.Property(t => t.TimeCreated).HasColumnName("TIME_CREATED").IsRequired();
            builder.Property(t => t.TimeDeleted).HasColumnName("TIME_DELETED").IsRequired(false);
            builder.ToTable("Permissions");
        }
    }
}