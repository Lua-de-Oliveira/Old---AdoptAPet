using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdoptAPet.Migrations
{
    public partial class Shelter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShelterID",
                table: "Animals",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shelters",
                columns: table => new
                {
                    ShelterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CpfOrCnpj = table.Column<string>(nullable: true),
                    SocialMedia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelters", x => x.ShelterID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ShelterID",
                table: "Animals",
                column: "ShelterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Shelters_ShelterID",
                table: "Animals",
                column: "ShelterID",
                principalTable: "Shelters",
                principalColumn: "ShelterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Shelters_ShelterID",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "Shelters");

            migrationBuilder.DropIndex(
                name: "IX_Animals_ShelterID",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "ShelterID",
                table: "Animals");
        }
    }
}
