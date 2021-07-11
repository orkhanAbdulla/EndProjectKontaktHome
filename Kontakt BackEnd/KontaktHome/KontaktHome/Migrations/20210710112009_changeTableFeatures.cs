using Microsoft.EntityFrameworkCore.Migrations;

namespace KontaktHome.Migrations
{
    public partial class changeTableFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Features_FeaturesId",
                table: "ProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetail_FeaturesId",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "FeaturesId",
                table: "ProductDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeaturesId",
                table: "ProductDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_FeaturesId",
                table: "ProductDetail",
                column: "FeaturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Features_FeaturesId",
                table: "ProductDetail",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
