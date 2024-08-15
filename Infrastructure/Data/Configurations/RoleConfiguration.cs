using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(t => t.RoleId)
            .HasColumnName("ROLE_ID");

            builder.Property(t => t.Name)
            .HasColumnName("NAME");

            builder.HasMany(r => r.Permissions)
            .WithMany(p => p.Roles)
            .UsingEntity(e => e.ToTable("Role_Permissions"));

        }
    }
}