using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;  

namespace Infrastructure.Data.Configurations
{
    public class UserProfileConfiguration : BaseEntityConfiguration<UserProfile>, IEntityTypeConfiguration<UserProfile>
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

            builder.ToTable("Profiles");      
            }
    }
}