using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Grad
    {
        [Key]
        public int GradId { get; set; }
        public string Naziv { get; set; }

        [ForeignKey("Drzava")]
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
    }
}
