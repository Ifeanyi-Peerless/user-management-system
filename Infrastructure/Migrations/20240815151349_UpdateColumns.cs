using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_Users_USER_PROFILE_ID",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "Profiles");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Users",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Users",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Users",
                newName: "TIME_CREATED");

            migrationBuilder.RenameColumn(
                name: "TimeApproved",
                table: "Users",
                newName: "TIME_APPROVED");

            migrationBuilder.RenameColumn(
                name: "LastModifiedTime",
                table: "Users",
                newName: "LAST_MODIFIED_TIME");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Users",
                newName: "LAST_MODIFIED_DATE");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Users",
                newName: "LAST_MODIFIED_BY");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Users",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "HashValue",
                table: "Users",
                newName: "HASH_VALUE");

            migrationBuilder.RenameColumn(
                name: "DeletedFlag",
                table: "Users",
                newName: "DELETED_FLAG");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Users",
                newName: "DELETED_BY");

            migrationBuilder.RenameColumn(
                name: "DateDeleted",
                table: "Users",
                newName: "DATE_DELETED");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Users",
                newName: "DATE_CREATED");

            migrationBuilder.RenameColumn(
                name: "DateApproved",
                table: "Users",
                newName: "DATE_APPROVED");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Users",
                newName: "CREATED_BY");

            migrationBuilder.RenameColumn(
                name: "ApprovedBy",
                table: "Users",
                newName: "APPROVED_BY");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Roles",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Roles",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Roles",
                newName: "TIME_CREATED");

            migrationBuilder.RenameColumn(
                name: "TimeApproved",
                table: "Roles",
                newName: "TIME_APPROVED");

            migrationBuilder.RenameColumn(
                name: "LastModifiedTime",
                table: "Roles",
                newName: "LAST_MODIFIED_TIME");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Roles",
                newName: "LAST_MODIFIED_DATE");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Roles",
                newName: "LAST_MODIFIED_BY");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Roles",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "HashValue",
                table: "Roles",
                newName: "HASH_VALUE");

            migrationBuilder.RenameColumn(
                name: "DeletedFlag",
                table: "Roles",
                newName: "DELETED_FLAG");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Roles",
                newName: "DELETED_BY");

            migrationBuilder.RenameColumn(
                name: "DateDeleted",
                table: "Roles",
                newName: "DATE_DELETED");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Roles",
                newName: "DATE_CREATED");

            migrationBuilder.RenameColumn(
                name: "DateApproved",
                table: "Roles",
                newName: "DATE_APPROVED");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Roles",
                newName: "CREATED_BY");

            migrationBuilder.RenameColumn(
                name: "ApprovedBy",
                table: "Roles",
                newName: "APPROVED_BY");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Permissions",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Permissions",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Permissions",
                newName: "TIME_CREATED");

            migrationBuilder.RenameColumn(
                name: "TimeApproved",
                table: "Permissions",
                newName: "TIME_APPROVED");

            migrationBuilder.RenameColumn(
                name: "LastModifiedTime",
                table: "Permissions",
                newName: "LAST_MODIFIED_TIME");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Permissions",
                newName: "LAST_MODIFIED_DATE");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Permissions",
                newName: "LAST_MODIFIED_BY");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Permissions",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "HashValue",
                table: "Permissions",
                newName: "HASH_VALUE");

            migrationBuilder.RenameColumn(
                name: "DeletedFlag",
                table: "Permissions",
                newName: "DELETED_FLAG");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Permissions",
                newName: "DELETED_BY");

            migrationBuilder.RenameColumn(
                name: "DateDeleted",
                table: "Permissions",
                newName: "DATE_DELETED");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Permissions",
                newName: "DATE_CREATED");

            migrationBuilder.RenameColumn(
                name: "DateApproved",
                table: "Permissions",
                newName: "DATE_APPROVED");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Permissions",
                newName: "CREATED_BY");

            migrationBuilder.RenameColumn(
                name: "ApprovedBy",
                table: "Permissions",
                newName: "APPROVED_BY");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Profiles",
                newName: "STATUS");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Profiles",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Profiles",
                newName: "TIME_CREATED");

            migrationBuilder.RenameColumn(
                name: "TimeApproved",
                table: "Profiles",
                newName: "TIME_APPROVED");

            migrationBuilder.RenameColumn(
                name: "LastModifiedTime",
                table: "Profiles",
                newName: "LAST_MODIFIED_TIME");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Profiles",
                newName: "LAST_MODIFIED_DATE");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "Profiles",
                newName: "LAST_MODIFIED_BY");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Profiles",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "HashValue",
                table: "Profiles",
                newName: "HASH_VALUE");

            migrationBuilder.RenameColumn(
                name: "DeletedFlag",
                table: "Profiles",
                newName: "DELETED_FLAG");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Profiles",
                newName: "DELETED_BY");

            migrationBuilder.RenameColumn(
                name: "DateDeleted",
                table: "Profiles",
                newName: "DATE_DELETED");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Profiles",
                newName: "DATE_CREATED");

            migrationBuilder.RenameColumn(
                name: "DateApproved",
                table: "Profiles",
                newName: "DATE_APPROVED");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Profiles",
                newName: "CREATED_BY");

            migrationBuilder.RenameColumn(
                name: "ApprovedBy",
                table: "Profiles",
                newName: "APPROVED_BY");

            migrationBuilder.AlterColumn<bool>(
                name: "STATUS",
                table: "Users",
                type: "bool",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LAST_MODIFIED_DATE",
                table: "Users",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LAST_MODIFIED_BY",
                table: "Users",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HASH_VALUE",
                table: "Users",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DELETED_FLAG",
                table: "Users",
                type: "bool",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "DELETED_BY",
                table: "Users",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_CREATED",
                table: "Users",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CREATED_BY",
                table: "Users",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "APPROVED_BY",
                table: "Users",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "STATUS",
                table: "Roles",
                type: "bool",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LAST_MODIFIED_DATE",
                table: "Roles",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LAST_MODIFIED_BY",
                table: "Roles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HASH_VALUE",
                table: "Roles",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DELETED_FLAG",
                table: "Roles",
                type: "bool",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "DELETED_BY",
                table: "Roles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_CREATED",
                table: "Roles",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CREATED_BY",
                table: "Roles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "APPROVED_BY",
                table: "Roles",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "STATUS",
                table: "Permissions",
                type: "bool",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LAST_MODIFIED_DATE",
                table: "Permissions",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LAST_MODIFIED_BY",
                table: "Permissions",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HASH_VALUE",
                table: "Permissions",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DELETED_FLAG",
                table: "Permissions",
                type: "bool",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "DELETED_BY",
                table: "Permissions",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_CREATED",
                table: "Permissions",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CREATED_BY",
                table: "Permissions",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "APPROVED_BY",
                table: "Permissions",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "STATUS",
                table: "Profiles",
                type: "bool",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LAST_MODIFIED_DATE",
                table: "Profiles",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LAST_MODIFIED_BY",
                table: "Profiles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HASH_VALUE",
                table: "Profiles",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DELETED_FLAG",
                table: "Profiles",
                type: "bool",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "DELETED_BY",
                table: "Profiles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_CREATED",
                table: "Profiles",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CREATED_BY",
                table: "Profiles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "APPROVED_BY",
                table: "Profiles",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "USER_PROFILE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_USER_PROFILE_ID",
                table: "Profiles",
                column: "USER_PROFILE_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_USER_PROFILE_ID",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "UserProfiles");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Users",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Users",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_CREATED",
                table: "Users",
                newName: "TimeCreated");

            migrationBuilder.RenameColumn(
                name: "TIME_APPROVED",
                table: "Users",
                newName: "TimeApproved");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Users",
                newName: "LastModifiedTime");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_DATE",
                table: "Users",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_BY",
                table: "Users",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "Users",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "HASH_VALUE",
                table: "Users",
                newName: "HashValue");

            migrationBuilder.RenameColumn(
                name: "DELETED_FLAG",
                table: "Users",
                newName: "DeletedFlag");

            migrationBuilder.RenameColumn(
                name: "DELETED_BY",
                table: "Users",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "DATE_DELETED",
                table: "Users",
                newName: "DateDeleted");

            migrationBuilder.RenameColumn(
                name: "DATE_CREATED",
                table: "Users",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DATE_APPROVED",
                table: "Users",
                newName: "DateApproved");

            migrationBuilder.RenameColumn(
                name: "CREATED_BY",
                table: "Users",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "APPROVED_BY",
                table: "Users",
                newName: "ApprovedBy");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Roles",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Roles",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_CREATED",
                table: "Roles",
                newName: "TimeCreated");

            migrationBuilder.RenameColumn(
                name: "TIME_APPROVED",
                table: "Roles",
                newName: "TimeApproved");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Roles",
                newName: "LastModifiedTime");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_DATE",
                table: "Roles",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_BY",
                table: "Roles",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "Roles",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "HASH_VALUE",
                table: "Roles",
                newName: "HashValue");

            migrationBuilder.RenameColumn(
                name: "DELETED_FLAG",
                table: "Roles",
                newName: "DeletedFlag");

            migrationBuilder.RenameColumn(
                name: "DELETED_BY",
                table: "Roles",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "DATE_DELETED",
                table: "Roles",
                newName: "DateDeleted");

            migrationBuilder.RenameColumn(
                name: "DATE_CREATED",
                table: "Roles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DATE_APPROVED",
                table: "Roles",
                newName: "DateApproved");

            migrationBuilder.RenameColumn(
                name: "CREATED_BY",
                table: "Roles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "APPROVED_BY",
                table: "Roles",
                newName: "ApprovedBy");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Permissions",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Permissions",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_CREATED",
                table: "Permissions",
                newName: "TimeCreated");

            migrationBuilder.RenameColumn(
                name: "TIME_APPROVED",
                table: "Permissions",
                newName: "TimeApproved");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Permissions",
                newName: "LastModifiedTime");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_DATE",
                table: "Permissions",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_BY",
                table: "Permissions",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "Permissions",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "HASH_VALUE",
                table: "Permissions",
                newName: "HashValue");

            migrationBuilder.RenameColumn(
                name: "DELETED_FLAG",
                table: "Permissions",
                newName: "DeletedFlag");

            migrationBuilder.RenameColumn(
                name: "DELETED_BY",
                table: "Permissions",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "DATE_DELETED",
                table: "Permissions",
                newName: "DateDeleted");

            migrationBuilder.RenameColumn(
                name: "DATE_CREATED",
                table: "Permissions",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DATE_APPROVED",
                table: "Permissions",
                newName: "DateApproved");

            migrationBuilder.RenameColumn(
                name: "CREATED_BY",
                table: "Permissions",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "APPROVED_BY",
                table: "Permissions",
                newName: "ApprovedBy");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "UserProfiles",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "UserProfiles",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_CREATED",
                table: "UserProfiles",
                newName: "TimeCreated");

            migrationBuilder.RenameColumn(
                name: "TIME_APPROVED",
                table: "UserProfiles",
                newName: "TimeApproved");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_TIME",
                table: "UserProfiles",
                newName: "LastModifiedTime");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_DATE",
                table: "UserProfiles",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LAST_MODIFIED_BY",
                table: "UserProfiles",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "UserProfiles",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "HASH_VALUE",
                table: "UserProfiles",
                newName: "HashValue");

            migrationBuilder.RenameColumn(
                name: "DELETED_FLAG",
                table: "UserProfiles",
                newName: "DeletedFlag");

            migrationBuilder.RenameColumn(
                name: "DELETED_BY",
                table: "UserProfiles",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "DATE_DELETED",
                table: "UserProfiles",
                newName: "DateDeleted");

            migrationBuilder.RenameColumn(
                name: "DATE_CREATED",
                table: "UserProfiles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DATE_APPROVED",
                table: "UserProfiles",
                newName: "DateApproved");

            migrationBuilder.RenameColumn(
                name: "CREATED_BY",
                table: "UserProfiles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "APPROVED_BY",
                table: "UserProfiles",
                newName: "ApprovedBy");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Users",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashValue",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DeletedFlag",
                table: "Users",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Roles",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Roles",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashValue",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DeletedFlag",
                table: "Roles",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Roles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Permissions",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Permissions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Permissions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashValue",
                table: "Permissions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DeletedFlag",
                table: "Permissions",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Permissions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Permissions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Permissions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Permissions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "UserProfiles",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedDate",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "UserProfiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HashValue",
                table: "UserProfiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DeletedFlag",
                table: "UserProfiles",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "UserProfiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "UserProfiles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserProfiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "UserProfiles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "USER_PROFILE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_Users_USER_PROFILE_ID",
                table: "UserProfiles",
                column: "USER_PROFILE_ID",
                principalTable: "Users",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
