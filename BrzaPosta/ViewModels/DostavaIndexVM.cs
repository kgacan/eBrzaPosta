using BrzaPosta.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class DostavaIndexVM
    {
        public List<DostavaVM> dostaveZaHtml { get; set; }
        public int brojDostava { get; set; }
        public class DostavaVM
        {
            public int DostavaId { get; set; }
            public string Posiljalac { get; set; }
            public string Dostavljac { get; set; }
            public string Primalac { get; set; }
            public string Platilac { get; set; }
        }

    }
}
