using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdoptAPet.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Animals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Animals",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryID",
                table: "Animals",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Categories_CategoryID",
                table: "Animals",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Categories_CategoryID",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Animals_CategoryID",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Animals");
        }
    }
}
