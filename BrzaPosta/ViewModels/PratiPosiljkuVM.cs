using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class PratiPosiljkuVM
    {
        public int dostavaId { get; set; }
        public string Sifra { get; set; }
        public string Dostavljac { get; set; }
        public string TrenutnaAdresa { get; set; }
    }
}
