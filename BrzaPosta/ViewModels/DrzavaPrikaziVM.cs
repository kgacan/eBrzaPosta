using BrzaPosta.EntityModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class DrzavaPrikaziVM
    {
        public class RegionVM
        {
            public int RegionId { get; set; }
            public string Naziv { get; set; }
        }
        public class DrzavaVM
        {
            public int DrzavaId { get; set; }
            public string Naziv { get; set; }
            public int RegionId { get; set; }
            public string Region_Naziv { get; set; }
            
        }
        public List<DrzavaVM> podaciZaHtml { get; set; }
        public List<SelectListItem> RegioniZaSelectTag { get; set; }
        public int RegionIdZaSelect { get; set; }
    }
}

