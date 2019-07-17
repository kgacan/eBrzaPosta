using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Drzava
    {
        [Key]
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("Region")]
        public int RegionId { get; set; }
        public Region Region { get; set; }

    }
}
