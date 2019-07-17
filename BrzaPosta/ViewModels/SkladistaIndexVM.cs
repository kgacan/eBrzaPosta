using BrzaPosta.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class SkladistaIndexVM
    {
            public int SkladisteId { get; set; }
            public string Adresa { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
            //public Adresa adresaSkladista { get; set; }
    }
}
