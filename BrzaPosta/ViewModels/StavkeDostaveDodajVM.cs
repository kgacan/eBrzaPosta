using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class StavkeDostaveDodajVM
    {
        public int PosiljalacID { get; set; }
        public int DostavaID { get; set; }
        public int StavkaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string BrojStavke { get; set; }
        public double Tezina { get; set; }
        public int VrstaId { get; set; }
        public List<SelectListItem> vrsteStavki { get; set; }
        //public string NazivVrste { get; set; }
        public int UkupnoDodanoStavki { get; set; }
    }
}
