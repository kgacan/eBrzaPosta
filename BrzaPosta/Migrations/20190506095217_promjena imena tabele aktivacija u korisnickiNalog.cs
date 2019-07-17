using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Web.Migrations
{
    public partial class promjenaimenatabeleaktivacijaukorisnickiNalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_administratori_aktivacije_AktivacijaId",
                table: "administratori");

            migrationBuilder.DropForeignKey(
                name: "FK_korisnici_aktivacije_AktivacijaId",
                table: "korisnici");

            migrationBuilder.DropTable(
                name: "aktivacije");

            migrationBuilder.CreateTable(
                name: "korisnickiNalog",
                columns: table => new
                {
                    korisnickiNalogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnickiNalog", x => x.korisnickiNalogId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_administratori_korisnickiNalog_AktivacijaId",
                table: "administratori",
                column: "AktivacijaId",
                principalTable: "korisnickiNalog",
                principalColumn: "korisnickiNalogId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_korisnici_korisnickiNalog_AktivacijaId",
                table: "korisnici",
                column: "AktivacijaId",
                principalTable: "korisnickiNalog",
                principalColumn: "korisnickiNalogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_administratori_korisnickiNalog_AktivacijaId",
                table: "administratori");

            migrationBuilder.DropForeignKey(
                name: "FK_korisnici_korisnickiNalog_AktivacijaId",
                table: "korisnici");

            migrationBuilder.DropTable(
                name: "korisnickiNalog");

            migrationBuilder.CreateTable(
                name: "aktivacije",
                columns: table => new
                {
                    AktivacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aktivacije", x => x.AktivacijaId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_administratori_aktivacije_AktivacijaId",
                table: "administratori",
                column: "AktivacijaId",
                principalTable: "aktivacije",
                principalColumn: "AktivacijaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_korisnici_aktivacije_AktivacijaId",
                table: "korisnici",
                column: "AktivacijaId",
                principalTable: "aktivacije",
                principalColumn: "AktivacijaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
