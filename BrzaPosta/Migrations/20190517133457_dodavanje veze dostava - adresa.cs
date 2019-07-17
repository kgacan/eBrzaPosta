using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Web.Migrations
{
    public partial class dodavanjevezedostavaadresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresaId",
                table: "dostave",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_dostave_AdresaId",
                table: "dostave",
                column: "AdresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_dostave_adrese_AdresaId",
                table: "dostave",
                column: "AdresaId",
                principalTable: "adrese",
                principalColumn: "AdresaId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dostave_adrese_AdresaId",
                table: "dostave");

            migrationBuilder.DropIndex(
                name: "IX_dostave_AdresaId",
                table: "dostave");

            migrationBuilder.DropColumn(
                name: "AdresaId",
                table: "dostave");
        }
    }
}
