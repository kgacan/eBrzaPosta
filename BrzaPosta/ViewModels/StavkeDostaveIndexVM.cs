using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class StavkeDostaveIndexVM
    {
        public List<StavkeDostaveVM> listaStavkeDostave { get; set; }
        public int DostavaId { get; set; }
        public int PosiljalacId { get; set; }

        public class StavkeDostaveVM
        {
            public int StavkaId { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
            public string BrojStavke { get; set; }
            public double Tezina { get; set; }
            public int DostavaId { get; set; }
            public int VrstaId { get; set; }
            public string NazivVrste { get; set; }
        }
    }
}
