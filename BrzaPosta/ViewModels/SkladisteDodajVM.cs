using BrzaPosta.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class SkladisteDodajVM
    {
        public int SkladisteId { get; set; }
        //[Remote(action: nameof(SkladisteController.ProvjeriNaziv), controller: "Skladiste")]
        [Required]
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int GradId { get; set; }
        public List<SelectListItem> gradovi { get; set; }
        //[Remote(action: nameof(SkladisteController.ProvjeriAdresu), controller: "Skladiste")]
        public int AdresaId { get; set; }
        public List<SelectListItem> adrese { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool uredjivanje { get; set; }
    }
}
