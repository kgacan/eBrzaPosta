using BrzaPosta.EntityModels;
using BrzaPosta.Web.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EF
{
    public class BrzaPostaDbContext : DbContext
    {

        public BrzaPostaDbContext(DbContextOptions options):base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Server=app.fit.ba,1433;Database=p1802;Trusted_Connection=False;MultipleActiveResultSets=true;User ID=p1802;Password=TYA74d!");
        //    optionsBuilder.UseSqlServer("Server=.;Database=p1802_seminarski;Trusted_Connection=True;MultipleActiveResultSets=true;");

        //}

        public DbSet<Zaposlenik> zaposlenici { get; set; }
        public DbSet<Adresa> adrese { get; set; }
        public DbSet<KorisnickiNalog> korisnickiNalog { get; set; }
        public DbSet<Dostava> dostave { get; set; }
        public DbSet<Drzava> drzave { get; set; }
        public DbSet<Grad> gradovi { get; set; }
        public DbSet<Korisnik> korisnici { get; set; }
        public DbSet<Ocjena> ocjene { get; set; }
        public DbSet<Region> regioni { get; set; }
        public DbSet<Skladiste> skladista { get; set; }
        public DbSet<Status> statusi { get; set; }
        public DbSet<StavkeDostave> stavkeDostave { get; set; }
        public DbSet<Vozilo> vozila { get; set; }
        public DbSet<VrstaStavki> vrsteStavki { get; set; }
        public DbSet<Administrator> administratori { get; set; }
        public DbSet<AutorizacijskiToken> autorizacijskiToken { get; set; }
    }
}
