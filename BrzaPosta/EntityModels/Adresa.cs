using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Adresa
    {
        [Key]
        public int AdresaId { get; set; }
        public string Ulica { get; set; }
        public string BrUlice { get; set; }
        public string PostnskiBroj { get; set; }
        public bool Aktivna { get; set; }

        [ForeignKey("Grad")]
        public int GradId { get; set; }
        public Grad Grad { get; set; }

    }
}
