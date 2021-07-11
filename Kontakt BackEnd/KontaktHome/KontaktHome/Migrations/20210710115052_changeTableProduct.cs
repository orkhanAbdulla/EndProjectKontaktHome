using Microsoft.EntityFrameworkCore.Migrations;

namespace KontaktHome.Migrations
{
    public partial class changeTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Memory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SaleCount",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaleCount",
                table: "Products",
                type: "int",
                nullable: true);
        }
    }
}
