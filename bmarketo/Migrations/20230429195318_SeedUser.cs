using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketo.Migrations
{
    /// <inheritdoc />
    public partial class SeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a77ef48e-4309-4aa0-b7b1-2f49a51a83ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a15ca813-c96a-42d5-968b-5ada012c4b0e", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageURL", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "89fa7ea0-3499-469e-a2fd-5dbc2903a1dd", 0, null, "0e87509a-cabc-4b08-850d-ddc93313d9a1", null, false, "admin", null, "SystemAdministrator", false, null, null, null, "AQAAAAIAAYagAAAAECY+eAH+AaOh8rkHiZnuFQkEdsm1crIukBw1AV06Gvu3+OfmiN0sUgWCqhyh5d8Q1w==", null, false, "9e58dbcf-822f-4f32-b547-5a7d1504adda", false, "administrator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a15ca813-c96a-42d5-968b-5ada012c4b0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89fa7ea0-3499-469e-a2fd-5dbc2903a1dd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a77ef48e-4309-4aa0-b7b1-2f49a51a83ea", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });
        }
    }
}
