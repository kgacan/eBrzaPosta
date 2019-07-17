using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Web.Migrations
{
    public partial class dodavanjetabeleAutoritzacijskiToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autorizacijskiToken",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vrijednost = table.Column<string>(nullable: true),
                    VrijemeEvidentiranja = table.Column<DateTime>(nullable: false),
                    IpAdresa = table.Column<string>(nullable: true),
                    KorisnickiNalogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autorizacijskiToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_autorizacijskiToken_korisnickiNalog_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "korisnickiNalog",
                        principalColumn: "korisnickiNalogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_autorizacijskiToken_KorisnickiNalogId",
                table: "autorizacijskiToken",
                column: "KorisnickiNalogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autorizacijskiToken");
        }
    }
}
