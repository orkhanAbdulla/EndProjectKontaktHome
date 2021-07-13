using Microsoft.EntityFrameworkCore.Migrations;

namespace KontaktHome.Migrations
{
    public partial class changeCategoryFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categoryFeatures_Categories_CategoryId",
                table: "categoryFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_categoryFeatures_Features_FeaturesId",
                table: "categoryFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoryFeatures",
                table: "categoryFeatures");

            migrationBuilder.RenameTable(
                name: "categoryFeatures",
                newName: "CategoryFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_categoryFeatures_FeaturesId",
                table: "CategoryFeatures",
                newName: "IX_CategoryFeatures_FeaturesId");

            migrationBuilder.RenameIndex(
                name: "IX_categoryFeatures_CategoryId",
                table: "CategoryFeatures",
                newName: "IX_CategoryFeatures_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryFeatures",
                table: "CategoryFeatures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryFeatures_Categories_CategoryId",
                table: "CategoryFeatures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryFeatures_Features_FeaturesId",
                table: "CategoryFeatures",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryFeatures_Categories_CategoryId",
                table: "CategoryFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryFeatures_Features_FeaturesId",
                table: "CategoryFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryFeatures",
                table: "CategoryFeatures");

            migrationBuilder.RenameTable(
                name: "CategoryFeatures",
                newName: "categoryFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryFeatures_FeaturesId",
                table: "categoryFeatures",
                newName: "IX_categoryFeatures_FeaturesId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryFeatures_CategoryId",
                table: "categoryFeatures",
                newName: "IX_categoryFeatures_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoryFeatures",
                table: "categoryFeatures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categoryFeatures_Categories_CategoryId",
                table: "categoryFeatures",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_categoryFeatures_Features_FeaturesId",
                table: "categoryFeatures",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
