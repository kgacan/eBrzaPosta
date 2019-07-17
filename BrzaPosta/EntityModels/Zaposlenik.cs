using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Zaposlenik
    {
        [Key]
        public int ZaposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Aktivan { get; set; }
        public int Tip { get; set; }


        [ForeignKey("Aktivacija")]
        public int? AktivacijaId { get; set; }
        public KorisnickiNalog Aktivacija { get; set; }
    }
}
