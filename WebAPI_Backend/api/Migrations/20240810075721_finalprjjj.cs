using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class finalprjjj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a14f45a-eab1-4171-ac1e-05550177f46f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "298e69e7-ad9b-4e61-a8fe-aa2ffe45df00");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cf72947-5cb1-4393-9664-50dee8fe9b4d", null, "Admin", "ADMIN" },
                    { "38f6c4f2-40e2-4f21-9f04-5ca958a52c1f", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cf72947-5cb1-4393-9664-50dee8fe9b4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38f6c4f2-40e2-4f21-9f04-5ca958a52c1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a14f45a-eab1-4171-ac1e-05550177f46f", null, "User", "USER" },
                    { "298e69e7-ad9b-4e61-a8fe-aa2ffe45df00", null, "Admin", "ADMIN" }
                });
        }
    }
}
