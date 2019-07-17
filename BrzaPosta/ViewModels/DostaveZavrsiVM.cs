using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static BrzaPosta.Web.Helper.Enums;

namespace BrzaPosta.Web.ViewModels
{
    public class DostaveZavrsiVM
    {
        [EnumDataType(typeof(Status))]
        public Status status { get; set; }
        public string Opis { get; set; }
        public DateTime DatumStatusa{ get; set; }
        public int DostavaId{ get; set; }
    }
}
