using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class AdresaIndexVM
    {

        public List<AdresaVM> AdreseZaHtml { get; set; }
        public int GradID { get; set; }
        public class AdresaVM
        {
            public int AdresaId { get; set; }
            public string Ulica { get; set; }
            public string BrUlice { get; set; }
            public string PostnskiBroj { get; set; }
            public bool Aktivna { get; set; }
        }
    }
}
