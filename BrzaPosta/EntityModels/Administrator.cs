using BrzaPosta.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.EntityModels
{
    public class Administrator
    {
        [Key]
        public int AdminId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        [ForeignKey("Aktivacija")]
        public int? AktivacijaId { get; set; }
        public KorisnickiNalog Aktivacija { get; set; }
    }
}
