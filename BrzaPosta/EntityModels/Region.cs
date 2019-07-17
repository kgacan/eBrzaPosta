using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string Naziv { get; set; }
    }
}
