using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(t => t.UserId)
            .HasColumnName("USER_ID");

            builder.Property(t => t.Firstname)
            .HasColumnName("FIRST_NAME");

            builder.Property(t => t.Lastname)
            .HasColumnName("LAST_NAME");

            builder.Property(t => t.Email)
            .HasColumnName("EMAIL");

            builder.Property(t => t.Password)
            .HasColumnName("PASSWORD");

            builder.HasMany(t => t.Roles)
            .WithMany(r => r.Users)
            .UsingEntity(e => e.ToTable("User_Roles"));

            builder.HasOne(t => t.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<UserProfile>(p => p.UserProfileId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}