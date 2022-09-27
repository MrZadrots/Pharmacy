using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Phramacy.Migrations.AppDbContentMigrations
{
    public partial class Shelf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "shelf_life",
                table: "Product_Db",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "shelf_life",
                table: "Product_Db");
        }
    }
}
