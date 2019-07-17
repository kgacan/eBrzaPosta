using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class StavkeDostave
    {
        [Key]
        public int StavkaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string BrojStavke { get; set; }
        public double Tezina { get; set; }

        [ForeignKey("Dostava")]
        public int DostavaId { get; set; }
        public Dostava Dostava { get; set; }

        [ForeignKey("VrstaStravki")]
        public int VrstaId { get; set; }
        public VrstaStavki Vrsta { get; set; }
    }
}
