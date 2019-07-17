using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrzaPosta.Web.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aktivacije",
                columns: table => new
                {
                    AktivacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aktivacije", x => x.AktivacijaId);
                });

            migrationBuilder.CreateTable(
                name: "regioni",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regioni", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "vrsteStavki",
                columns: table => new
                {
                    VrstaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vrsteStavki", x => x.VrstaId);
                });

            migrationBuilder.CreateTable(
                name: "zaposlenici",
                columns: table => new
                {
                    ZaposlenikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Aktivan = table.Column<bool>(nullable: false),
                    Tip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zaposlenici", x => x.ZaposlenikId);
                });

            migrationBuilder.CreateTable(
                name: "administratori",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AktivacijaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administratori", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_administratori_aktivacije_AktivacijaId",
                        column: x => x.AktivacijaId,
                        principalTable: "aktivacije",
                        principalColumn: "AktivacijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "drzave",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drzave", x => x.DrzavaId);
                    table.ForeignKey(
                        name: "FK_drzave_regioni_RegionId",
                        column: x => x.RegionId,
                        principalTable: "regioni",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vozila",
                columns: table => new
                {
                    VoziloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DostavljacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vozila", x => x.VoziloId);
                    table.ForeignKey(
                        name: "FK_vozila_zaposlenici_DostavljacId",
                        column: x => x.DostavljacId,
                        principalTable: "zaposlenici",
                        principalColumn: "ZaposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gradovi",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gradovi", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_gradovi_drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "adrese",
                columns: table => new
                {
                    AdresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ulica = table.Column<string>(nullable: true),
                    BrUlice = table.Column<string>(nullable: true),
                    PostnskiBroj = table.Column<string>(nullable: true),
                    Aktivna = table.Column<bool>(nullable: false),
                    GradId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adrese", x => x.AdresaId);
                    table.ForeignKey(
                        name: "FK_adrese_gradovi_GradId",
                        column: x => x.GradId,
                        principalTable: "gradovi",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Aktivan = table.Column<bool>(nullable: false),
                    Registrovan = table.Column<bool>(nullable: false),
                    AdresaId = table.Column<int>(nullable: false),
                    AktivacijaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnici", x => x.KorisnikId);
                    table.ForeignKey(
                        name: "FK_korisnici_adrese_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "adrese",
                        principalColumn: "AdresaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_korisnici_aktivacije_AktivacijaId",
                        column: x => x.AktivacijaId,
                        principalTable: "aktivacije",
                        principalColumn: "AktivacijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "skladista",
                columns: table => new
                {
                    SkladisteId = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skladista", x => x.SkladisteId);
                    table.ForeignKey(
                        name: "FK_skladista_adrese_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "adrese",
                        principalColumn: "AdresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dostave",
                columns: table => new
                {
                    DostavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumDostave = table.Column<DateTime>(nullable: false),
                    DatumKreiranja = table.Column<DateTime>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(nullable: false),
                    Prioritet = table.Column<int>(nullable: false),
                    Aktivna = table.Column<bool>(nullable: false),
                    BrojDostave = table.Column<string>(nullable: true),
                    Tezina = table.Column<double>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    DostavljacId = table.Column<int>(nullable: false),
                    PosiljalacId = table.Column<int>(nullable: false),
                    PrimalacId = table.Column<int>(nullable: false),
                    PlatilacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dostave", x => x.DostavaId);
                    table.ForeignKey(
                        name: "FK_dostave_zaposlenici_DostavljacId",
                        column: x => x.DostavljacId,
                        principalTable: "zaposlenici",
                        principalColumn: "ZaposlenikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dostave_korisnici_PlatilacId",
                        column: x => x.PlatilacId,
                        principalTable: "korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dostave_korisnici_PosiljalacId",
                        column: x => x.PosiljalacId,
                        principalTable: "korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_dostave_korisnici_PrimalacId",
                        column: x => x.PrimalacId,
                        principalTable: "korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ocjene",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OcjenaDostave = table.Column<int>(nullable: false),
                    OpisOcjene = table.Column<string>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    DostavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ocjene", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_ocjene_dostave_DostavaId",
                        column: x => x.DostavaId,
                        principalTable: "dostave",
                        principalColumn: "DostavaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ocjene_korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "statusi",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusDostave = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    DatumIzmjene = table.Column<DateTime>(nullable: false),
                    DostavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusi", x => x.StatusId);
                    table.ForeignKey(
                        name: "FK_statusi_dostave_DostavaId",
                        column: x => x.DostavaId,
                        principalTable: "dostave",
                        principalColumn: "DostavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stavkeDostave",
                columns: table => new
                {
                    StavkaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    BrojStavke = table.Column<string>(nullable: true),
                    Tezina = table.Column<double>(nullable: false),
                    DostavaId = table.Column<int>(nullable: false),
                    VrstaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stavkeDostave", x => x.StavkaId);
                    table.ForeignKey(
                        name: "FK_stavkeDostave_dostave_DostavaId",
                        column: x => x.DostavaId,
                        principalTable: "dostave",
                        principalColumn: "DostavaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stavkeDostave_vrsteStavki_VrstaId",
                        column: x => x.VrstaId,
                        principalTable: "vrsteStavki",
                        principalColumn: "VrstaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_administratori_AktivacijaId",
                table: "administratori",
                column: "AktivacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_adrese_GradId",
                table: "adrese",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_dostave_DostavljacId",
                table: "dostave",
                column: "DostavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_dostave_PlatilacId",
                table: "dostave",
                column: "PlatilacId");

            migrationBuilder.CreateIndex(
                name: "IX_dostave_PosiljalacId",
                table: "dostave",
                column: "PosiljalacId");

            migrationBuilder.CreateIndex(
                name: "IX_dostave_PrimalacId",
                table: "dostave",
                column: "PrimalacId");

            migrationBuilder.CreateIndex(
                name: "IX_drzave_RegionId",
                table: "drzave",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_gradovi_DrzavaId",
                table: "gradovi",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_korisnici_AdresaId",
                table: "korisnici",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_korisnici_AktivacijaId",
                table: "korisnici",
                column: "AktivacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_ocjene_DostavaId",
                table: "ocjene",
                column: "DostavaId");

            migrationBuilder.CreateIndex(
                name: "IX_ocjene_KorisnikId",
                table: "ocjene",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_statusi_DostavaId",
                table: "statusi",
                column: "DostavaId");

            migrationBuilder.CreateIndex(
                name: "IX_stavkeDostave_DostavaId",
                table: "stavkeDostave",
                column: "DostavaId");

            migrationBuilder.CreateIndex(
                name: "IX_stavkeDostave_VrstaId",
                table: "stavkeDostave",
                column: "VrstaId");

            migrationBuilder.CreateIndex(
                name: "IX_vozila_DostavljacId",
                table: "vozila",
                column: "DostavljacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administratori");

            migrationBuilder.DropTable(
                name: "ocjene");

            migrationBuilder.DropTable(
                name: "skladista");

            migrationBuilder.DropTable(
                name: "statusi");

            migrationBuilder.DropTable(
                name: "stavkeDostave");

            migrationBuilder.DropTable(
                name: "vozila");

            migrationBuilder.DropTable(
                name: "dostave");

            migrationBuilder.DropTable(
                name: "vrsteStavki");

            migrationBuilder.DropTable(
                name: "zaposlenici");

            migrationBuilder.DropTable(
                name: "korisnici");

            migrationBuilder.DropTable(
                name: "adrese");

            migrationBuilder.DropTable(
                name: "aktivacije");

            migrationBuilder.DropTable(
                name: "gradovi");

            migrationBuilder.DropTable(
                name: "drzave");

            migrationBuilder.DropTable(
                name: "regioni");
        }
    }
}
