﻿using BrzaPosta.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.EntityModels
{
    public class AutorizacijskiToken
    {
            public int Id { get; set; }
            public string Vrijednost { get; set; }
            public DateTime VrijemeEvidentiranja { get; set; }
            public string IpAdresa { get; set; }
         
            [ForeignKey(nameof(KorisnickiNalog))]
            public int KorisnickiNalogId { get; set; }

            public KorisnickiNalog KorisnickiNalog { get; set; }

    }
}
