using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class KorisnickiNalog
    {
        [Key]
        public int korisnickiNalogId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
