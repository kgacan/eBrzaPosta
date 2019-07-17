using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Vozilo
    {
        [Key]
        public int VoziloId { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("Dostavljac")]
        public int DostavljacId { get; set; }
        public Zaposlenik Dostavljac { get; set; }

    }
}
