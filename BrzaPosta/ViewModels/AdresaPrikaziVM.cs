using BrzaPosta.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.ViewModels
{
    public class AdresaPrikaziVM
    {
        public int GradID { get; set; }
        public Grad Grad { get; set; }
        public Drzava Drzava { get; set; }
    }
}
