using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketo.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a77ef48e-4309-4aa0-b7b1-2f49a51a83ea", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a77ef48e-4309-4aa0-b7b1-2f49a51a83ea");
        }
    }
}
