using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BrzaPosta.Web.ViewModels.StatusiIndexVM;
using static BrzaPosta.Web.ViewModels.StavkeDostaveIndexVM;

namespace BrzaPosta.Web.ViewModels
{
    public class DostaveDetaljiVM
    {
        public int DostavaID { get; set; }
        public string DatumDostave { get; set; }
        public string DatumKreiranja { get; set; }
        public string DatumIzmjene { get; set; }
        public int Prioritet { get; set; }
        public string Aktivna { get; set; }
        public string BrojDostave { get; set; }
        public double Tezina { get; set; }
        public double Cijena { get; set; }
        public string MjestoDostavljanja { get; set; }
        public bool IsZaposlenik { get; set; } = false;
        //public List<StavkeDostaveVM> listaStavkeDostave { get; set; }
        //public List<StatusiVM> listaStatusa { get; set; }
    }
}
