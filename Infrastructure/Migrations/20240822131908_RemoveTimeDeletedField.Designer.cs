﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240822131908_RemoveTimeDeletedField")]
    partial class RemoveTimeDeletedField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Permission", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("PERMISSION_ID");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("APPROVED_BY");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateOnly?>("DateApproved")
                        .HasColumnType("date")
                        .HasColumnName("DATE_APPROVED");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date")
                        .HasColumnName("DATE_CREATED");

                    b.Property<DateOnly?>("DateDeleted")
                        .HasColumnType("date")
                        .HasColumnName("DATE_DELETED");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DELETED_BY");

                    b.Property<bool>("DeletedFlag")
                        .HasColumnType("bool")
                        .HasColumnName("DELETED_FLAG");

                    b.Property<string>("HashValue")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("HASH_VALUE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("date")
                        .HasColumnName("LAST_MODIFIED_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<bool>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("bool")
                        .HasColumnName("STATUS");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ROLE_ID");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("APPROVED_BY");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateOnly?>("DateApproved")
                        .HasColumnType("date")
                        .HasColumnName("DATE_APPROVED");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date")
                        .HasColumnName("DATE_CREATED");

                    b.Property<DateOnly?>("DateDeleted")
                        .HasColumnType("date")
                        .HasColumnName("DATE_DELETED");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DELETED_BY");

                    b.Property<bool>("DeletedFlag")
                        .HasColumnType("bool")
                        .HasColumnName("DELETED_FLAG");

                    b.Property<string>("HashValue")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("HASH_VALUE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("date")
                        .HasColumnName("LAST_MODIFIED_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.Property<bool>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("bool")
                        .HasColumnName("STATUS");

                    b.HasKey("RoleId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("USER_ID");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("APPROVED_BY");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateOnly?>("DateApproved")
                        .HasColumnType("date")
                        .HasColumnName("DATE_APPROVED");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date")
                        .HasColumnName("DATE_CREATED");

                    b.Property<DateOnly?>("DateDeleted")
                        .HasColumnType("date")
                        .HasColumnName("DATE_DELETED");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DELETED_BY");

                    b.Property<bool>("DeletedFlag")
                        .HasColumnType("bool")
                        .HasColumnName("DELETED_FLAG");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("HashValue")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("HASH_VALUE");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("date")
                        .HasColumnName("LAST_MODIFIED_DATE");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("LAST_NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("PASSWORD");

                    b.Property<bool>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("bool")
                        .HasColumnName("STATUS");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid")
                        .HasColumnName("USER_PROFILE_ID");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("APPROVED_BY");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("BIO");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CREATED_BY");

                    b.Property<DateOnly?>("DateApproved")
                        .HasColumnType("date")
                        .HasColumnName("DATE_APPROVED");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date")
                        .HasColumnName("DATE_CREATED");

                    b.Property<DateOnly?>("DateDeleted")
                        .HasColumnType("date")
                        .HasColumnName("DATE_DELETED");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DELETED_BY");

                    b.Property<bool>("DeletedFlag")
                        .HasColumnType("bool")
                        .HasColumnName("DELETED_FLAG");

                    b.Property<string>("HashValue")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("HASH_VALUE");

                    b.Property<string>("Hobbies")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("HOBBIES");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_DELETED");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("LAST_MODIFIED_BY");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("date")
                        .HasColumnName("LAST_MODIFIED_DATE");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NATIONALITY");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("OCCUPATION");

                    b.Property<bool>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("bool")
                        .HasColumnName("STATUS");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("USER_ID");

                    b.HasKey("UserProfileId");

                    b.ToTable("Profiles", (string)null);
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.Property<Guid>("PermissionsPermissionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RolesRoleId")
                        .HasColumnType("uuid");

                    b.HasKey("PermissionsPermissionId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("Role_Permissions", (string)null);
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("RolesRoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UsersUserId")
                        .HasColumnType("uuid");

                    b.HasKey("RolesRoleId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("User_Roles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserProfile", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Domain.Entities.UserProfile", "UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.HasOne("Domain.Entities.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsPermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
