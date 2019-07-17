using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class DostavaDodajVM
    {
        public int DostavaId { get; set; }
        public DateTime DatumDostave { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public int Prioritet { get; set; }
        public bool Aktivna { get; set; }
        public string BrojDostave { get; set; }
        public double Tezina { get; set; }
        public double Cijena { get; set; }

        public int DostavljacId { get; set; }
        public List<SelectListItem> dostavljaci { get; set; }

        public int PrimalacId { get; set; }
        public int PlatilacId { get; set; }
        public List<SelectListItem> korisnici { get; set; }
        public int PosiljalacId { get; set; }
        public string posiljalac { get; set; }

        public int TrenutnaAdresaId { get; set; }
        public List<SelectListItem> adrese { get; set; }
    }
}
