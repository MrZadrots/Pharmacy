using Microsoft.EntityFrameworkCore.Migrations;

namespace Phramacy.Migrations
{
    public partial class _inital1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "6a9a752f-9215-47d6-984e-102eccdb4238");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31e343d3-5058-41db-ae16-0052f74fc97c", "AQAAAAEAACcQAAAAEAzbeGn7hCWrHGfx2Yq/5Itzww7E+Uy535xFbaUFzGsxXtuJYx1I+qlC7tJl8qKFTg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af10569-b018-4fe7-a380-7d6a14c70b74",
                column: "ConcurrencyStamp",
                value: "c2374981-cb44-49cc-9b47-9e7fe9fea7ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8ed4a42-5b1a-4531-a57b-cdd646397290", "AQAAAAEAACcQAAAAEGQnjDTRTE+gNRFdiH8Vk+k/rz9nYiYxnj94ehSjK65qwxYITjoz9Z1VdQ0gB+cEQg==" });
        }
    }
}
