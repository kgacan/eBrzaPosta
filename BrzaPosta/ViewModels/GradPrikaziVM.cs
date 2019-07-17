using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class GradPrikaziVM
    {
        public List<GradoviVM> gradoviZaHtml { get; set; }
        public class GradoviVM
        {
            public int GradId { get; set; }
            public string Naziv { get; set; }
        }

    }
}
