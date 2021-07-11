using Microsoft.EntityFrameworkCore.Migrations;

namespace KontaktHome.Migrations
{
    public partial class CtaegoryFeaturesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    FeaturesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryFeatures_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFeatures_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFeatures_CategoryId",
                table: "CategoryFeatures",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFeatures_FeaturesId",
                table: "CategoryFeatures",
                column: "FeaturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryFeatures");
        }
    }
}
