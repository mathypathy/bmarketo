using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketo.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8226b767-d5aa-42c1-836e-8f619d069ae6", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageURL", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66312b45-cf3d-4316-8bf8-0de3c91a71f2", 0, null, "448de1ba-d914-4ca2-af26-1c1b8cd20e17", "administrator@domain.com", false, " ", null, " ", false, null, null, null, "AQAAAAIAAYagAAAAEKj+mlj8MGailS0265wTcPH9HNntpOimd+tmyPjSI9y5By6KecN0XkyzZVSFMUsDaQ==", null, false, "d092a0e0-41ce-428c-ab28-963f3dac4a88", false, "administrator@domain.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8226b767-d5aa-42c1-836e-8f619d069ae6", "66312b45-cf3d-4316-8bf8-0de3c91a71f2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8226b767-d5aa-42c1-836e-8f619d069ae6", "66312b45-cf3d-4316-8bf8-0de3c91a71f2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8226b767-d5aa-42c1-836e-8f619d069ae6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66312b45-cf3d-4316-8bf8-0de3c91a71f2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageURL", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, null, "3b88d416-3175-400a-937c-baf2583ece10", null, false, "admin", null, "SystemAdministrator", false, null, null, null, "AQAAAAIAAYagAAAAEKl5Ycfz0mK0Fwmluc+IQySlFW2roIXfZKUBQEFKsc52MzfzLBjH/UG6v1O6F9HZCw==", null, false, "312fd37b-79a4-47a0-9be8-33efcbed943e", false, "administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }
    }
}
