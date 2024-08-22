using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTimeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TIME_APPROVED",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TIME_CREATED",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "TIME_APPROVED",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "TIME_CREATED",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TIME_APPROVED",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TIME_CREATED",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "LAST_MODIFIED_TIME",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "TIME_APPROVED",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "TIME_CREATED",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Users",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Roles",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Profiles",
                newName: "TimeDeleted");

            migrationBuilder.RenameColumn(
                name: "TIME_DELETED",
                table: "Permissions",
                newName: "TimeDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Users",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Roles",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Profiles",
                newName: "TIME_DELETED");

            migrationBuilder.RenameColumn(
                name: "TimeDeleted",
                table: "Permissions",
                newName: "TIME_DELETED");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LAST_MODIFIED_TIME",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TIME_APPROVED",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TIME_CREATED",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LAST_MODIFIED_TIME",
                table: "Roles",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TIME_APPROVED",
                table: "Roles",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TIME_CREATED",
                table: "Roles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LAST_MODIFIED_TIME",
                table: "Profiles",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TIME_APPROVED",
                table: "Profiles",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TIME_CREATED",
                table: "Profiles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LAST_MODIFIED_TIME",
                table: "Permissions",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TIME_APPROVED",
                table: "Permissions",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TIME_CREATED",
                table: "Permissions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
