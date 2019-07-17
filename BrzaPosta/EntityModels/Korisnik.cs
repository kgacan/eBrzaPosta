using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Korisnik
    {
        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool Aktivan { get; set; }
        public bool Registrovan { get; set; }

        [ForeignKey("Adresa")]
        public int AdresaId { get; set; }
        public Adresa Adresa { get; set; }

        [ForeignKey("Aktivacija")]
        public int? AktivacijaId { get; set; }
        public KorisnickiNalog Aktivacija { get; set; }
    }
}
