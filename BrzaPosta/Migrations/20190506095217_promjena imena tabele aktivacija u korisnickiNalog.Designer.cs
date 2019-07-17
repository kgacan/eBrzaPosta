﻿// <auto-generated />
using System;
using BrzaPosta.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrzaPosta.Web.Migrations
{
    [DbContext(typeof(BrzaPostaDbContext))]
    [Migration("20190506095217_promjena imena tabele aktivacija u korisnickiNalog")]
    partial class promjenaimenatabeleaktivacijaukorisnickiNalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrzaPosta.EntityModels.Adresa", b =>
                {
                    b.Property<int>("AdresaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna");

                    b.Property<string>("BrUlice");

                    b.Property<int>("GradId");

                    b.Property<string>("PostnskiBroj");

                    b.Property<string>("Ulica");

                    b.HasKey("AdresaId");

                    b.HasIndex("GradId");

                    b.ToTable("adrese");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Dostava", b =>
                {
                    b.Property<int>("DostavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna");

                    b.Property<string>("BrojDostave");

                    b.Property<double>("Cijena");

                    b.Property<DateTime>("DatumDostave");

                    b.Property<DateTime>("DatumIzmjene");

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<int>("DostavljacId");

                    b.Property<int>("PlatilacId");

                    b.Property<int>("PosiljalacId");

                    b.Property<int>("PrimalacId");

                    b.Property<int>("Prioritet");

                    b.Property<double>("Tezina");

                    b.HasKey("DostavaId");

                    b.HasIndex("DostavljacId");

                    b.HasIndex("PlatilacId");

                    b.HasIndex("PosiljalacId");

                    b.HasIndex("PrimalacId");

                    b.ToTable("dostave");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<int>("RegionId");

                    b.HasKey("DrzavaId");

                    b.HasIndex("RegionId");

                    b.ToTable("drzave");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId");

                    b.Property<string>("Naziv");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("gradovi");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("korisnickiNalogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("korisnickiNalogId");

                    b.ToTable("korisnickiNalog");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdresaId");

                    b.Property<int?>("AktivacijaId");

                    b.Property<bool>("Aktivan");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<bool>("Registrovan");

                    b.HasKey("KorisnikId");

                    b.HasIndex("AdresaId");

                    b.HasIndex("AktivacijaId");

                    b.ToTable("korisnici");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Ocjena", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DostavaId");

                    b.Property<int>("KorisnikId");

                    b.Property<int>("OcjenaDostave");

                    b.Property<string>("OpisOcjene");

                    b.HasKey("OcjenaId");

                    b.HasIndex("DostavaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("ocjene");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("RegionId");

                    b.ToTable("regioni");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Skladiste", b =>
                {
                    b.Property<int>("SkladisteId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("SkladisteId");

                    b.ToTable("skladista");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene");

                    b.Property<int>("DostavaId");

                    b.Property<string>("Opis");

                    b.Property<string>("StatusDostave");

                    b.HasKey("StatusId");

                    b.HasIndex("DostavaId");

                    b.ToTable("statusi");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.StavkeDostave", b =>
                {
                    b.Property<int>("StavkaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojStavke");

                    b.Property<int>("DostavaId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<double>("Tezina");

                    b.Property<int>("VrstaId");

                    b.HasKey("StavkaId");

                    b.HasIndex("DostavaId");

                    b.HasIndex("VrstaId");

                    b.ToTable("stavkeDostave");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Vozilo", b =>
                {
                    b.Property<int>("VoziloId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DostavljacId");

                    b.Property<string>("Naziv");

                    b.HasKey("VoziloId");

                    b.HasIndex("DostavljacId");

                    b.ToTable("vozila");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.VrstaStavki", b =>
                {
                    b.Property<int>("VrstaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("VrstaId");

                    b.ToTable("vrsteStavki");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.Property<int>("Tip");

                    b.Property<string>("Username");

                    b.HasKey("ZaposlenikId");

                    b.ToTable("zaposlenici");
                });

            modelBuilder.Entity("BrzaPosta.Web.EntityModels.Administrator", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AktivacijaId");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.HasKey("AdminId");

                    b.HasIndex("AktivacijaId");

                    b.ToTable("administratori");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Adresa", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Dostava", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Zaposlenik", "Dostavljac")
                        .WithMany()
                        .HasForeignKey("DostavljacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrzaPosta.EntityModels.Korisnik", "Platilac")
                        .WithMany()
                        .HasForeignKey("PlatilacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrzaPosta.EntityModels.Korisnik", "Posiljalac")
                        .WithMany()
                        .HasForeignKey("PosiljalacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrzaPosta.EntityModels.Korisnik", "Primalac")
                        .WithMany()
                        .HasForeignKey("PrimalacId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Drzava", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Grad", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Korisnik", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrzaPosta.EntityModels.KorisnickiNalog", "Aktivacija")
                        .WithMany()
                        .HasForeignKey("AktivacijaId");
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Ocjena", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Dostava", "Dostava")
                        .WithMany()
                        .HasForeignKey("DostavaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrzaPosta.EntityModels.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Skladiste", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("SkladisteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Status", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Dostava", "Dostava")
                        .WithMany()
                        .HasForeignKey("DostavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.StavkeDostave", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Dostava", "Dostava")
                        .WithMany()
                        .HasForeignKey("DostavaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrzaPosta.EntityModels.VrstaStavki", "Vrsta")
                        .WithMany()
                        .HasForeignKey("VrstaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.EntityModels.Vozilo", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.Zaposlenik", "Dostavljac")
                        .WithMany()
                        .HasForeignKey("DostavljacId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrzaPosta.Web.EntityModels.Administrator", b =>
                {
                    b.HasOne("BrzaPosta.EntityModels.KorisnickiNalog", "Aktivacija")
                        .WithMany()
                        .HasForeignKey("AktivacijaId");
                });
#pragma warning restore 612, 618
        }
    }
}