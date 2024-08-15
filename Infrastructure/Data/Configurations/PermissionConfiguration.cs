using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PermissionConfiguration : BaseEntityConfiguration<Permission>
    {
        public override void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.Property(t => t.PermissionId)
            .HasColumnName("PERMISSION_ID");

            builder.Property(t => t.Name)
            .HasColumnName("NAME");
        }
    }
}