using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class AdresaDodajVM
    {
        public int AdresaId { get; set; }
        [Required(ErrorMessage ="Ulica je obavezno polje!")]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Broj ulice je obavezno polje!")]
        public string BrUlice { get; set; }
        [Required(ErrorMessage = "Poštanski broj je obavezno polje!")]
        public string PostnskiBroj { get; set; }
        public bool Aktivna { get; set; }
        public int GradId { get; set; }
        public int SkladisteId { get; set; }
    }
}
