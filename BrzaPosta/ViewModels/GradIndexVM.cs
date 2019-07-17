using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class GradIndexVM
    {
        public int drzavaId { get; set; }
        public List<Row> gradoviZaHtml { get; set; }

        public class Row
        {
            public int GradId { get; set; }
            public string Naziv { get; set; }
        }
    }
}
