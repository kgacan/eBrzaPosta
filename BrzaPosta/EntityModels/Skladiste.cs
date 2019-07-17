using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Skladiste
    {
        [Key] [ForeignKey("Adresa")]
        public int SkladisteId { get; set; }
        public Adresa Adresa { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
