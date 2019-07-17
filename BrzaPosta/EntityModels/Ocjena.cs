using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Ocjena
    {
        [Key]
        public int OcjenaId { get; set; }
        public int OcjenaDostave { get; set; }
        public string OpisOcjene { get; set; }


        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey("Dostava")]
        public int DostavaId { get; set; }
        public Dostava Dostava { get; set; }
    }
}
