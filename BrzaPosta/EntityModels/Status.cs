using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusDostave { get; set; }
        public string Opis { get; set; }
        public DateTime DatumIzmjene { get; set; }

        [ForeignKey("Dostava")]
        public int DostavaId { get; set; }
        public Dostava Dostava { get; set; }
    }
}
