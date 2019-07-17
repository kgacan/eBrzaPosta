using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Web.Migrations
{
    public partial class dodavanjevezeizmedjuzaposelnikaikorisnickognaloga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AktivacijaId",
                table: "zaposlenici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_zaposlenici_AktivacijaId",
                table: "zaposlenici",
                column: "AktivacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_zaposlenici_korisnickiNalog_AktivacijaId",
                table: "zaposlenici",
                column: "AktivacijaId",
                principalTable: "korisnickiNalog",
                principalColumn: "korisnickiNalogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zaposlenici_korisnickiNalog_AktivacijaId",
                table: "zaposlenici");

            migrationBuilder.DropIndex(
                name: "IX_zaposlenici_AktivacijaId",
                table: "zaposlenici");

            migrationBuilder.DropColumn(
                name: "AktivacijaId",
                table: "zaposlenici");
        }
    }
}
