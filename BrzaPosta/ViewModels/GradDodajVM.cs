using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class GradDodajVM
    {
        public int drzavaId { get; set; }
        public int gradId { get; set; }
        [Required(ErrorMessage = "Polje grada je obavezno!")]
        [RegularExpression(@"[-a-zA-Z]{4,}")]
        public string naziv { get; set; }
    }
}
