using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Dal.Migrations
{
    public partial class ArtMartiaux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtMartial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SamouraiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtMartial_Samourai_SamouraiId",
                        column: x => x.SamouraiId,
                        principalTable: "Samourai",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartial_SamouraiId",
                table: "ArtMartial",
                column: "SamouraiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartial");
        }
    }
}
