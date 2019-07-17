using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class VrstaStavki
    {
        [Key]
        public int VrstaId { get; set; }
        public string Naziv { get; set; }
    }
}
