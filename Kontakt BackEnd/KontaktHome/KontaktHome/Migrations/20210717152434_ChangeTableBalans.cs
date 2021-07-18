using Microsoft.EntityFrameworkCore.Migrations;

namespace KontaktHome.Migrations
{
    public partial class ChangeTableBalans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Balans",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Balans",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
