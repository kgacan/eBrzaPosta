using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class DrzavaUrediVM
    {
        public int DrzavaId { get; set; }
        [Required(ErrorMessage = "Naziv je obavezno polje")]
        public string Naziv { get; set; }
        public int RegionId { get; set; }
        public List<SelectListItem> regioniZaHTML { get; set; }
    }
}
