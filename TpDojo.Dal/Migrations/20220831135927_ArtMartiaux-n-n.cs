using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Dal.Migrations
{
    public partial class ArtMartiauxnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartial_Samourai_SamouraiId",
                table: "ArtMartial");

            migrationBuilder.DropIndex(
                name: "IX_ArtMartial_SamouraiId",
                table: "ArtMartial");

            migrationBuilder.DropColumn(
                name: "SamouraiId",
                table: "ArtMartial");

            migrationBuilder.CreateTable(
                name: "ArtMartialSamourai",
                columns: table => new
                {
                    ArtMartiauxId = table.Column<int>(type: "int", nullable: false),
                    SamouraisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartialSamourai", x => new { x.ArtMartiauxId, x.SamouraisId });
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_ArtMartial_ArtMartiauxId",
                        column: x => x.ArtMartiauxId,
                        principalTable: "ArtMartial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_Samourai_SamouraisId",
                        column: x => x.SamouraisId,
                        principalTable: "Samourai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamourai_SamouraisId",
                table: "ArtMartialSamourai",
                column: "SamouraisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartialSamourai");

            migrationBuilder.AddColumn<int>(
                name: "SamouraiId",
                table: "ArtMartial",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartial_SamouraiId",
                table: "ArtMartial",
                column: "SamouraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartial_Samourai_SamouraiId",
                table: "ArtMartial",
                column: "SamouraiId",
                principalTable: "Samourai",
                principalColumn: "Id");
        }
    }
}
