using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;  

namespace Infrastructure.Data.Configurations
{
    public class UserProfileConfiguration : BaseEntityConfiguration<UserProfile>
    {
        public override void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(t => t.UserProfileId)
            .HasColumnName("USER_PROFILE_ID");

            builder.Property(t => t.UserId)
            .HasColumnName("USER_ID");

            builder.Property(t => t.Occupation)
            .HasColumnName("OCCUPATION");

            builder.Property(t => t.Nationality)
            .HasColumnName("NATIONALITY");

            builder.Property(t => t.Bio)
            .HasColumnName("BIO");
            
            builder.Property(e => e.Hobbies)
            .HasColumnName("HOBBIES")
            .HasConversion(
                v => JsonSerializer.Serialize(v, new JsonSerializerOptions { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull }), // Convert List<string> to string
                v => JsonSerializer.Deserialize<List<string>>(v, new JsonSerializerOptions { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull })  // Convert string to List<string>
            );        
            }
    }
}