using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BrzaPosta.Web.Helper.Enums;

namespace BrzaPosta.Web.ViewModels
{
    public class StatusiDodajVM
    {
        public StatusiVM Status { get; set; }
        private string _statusDescription;

        public class StatusiVM
        {
            public int StatusId { get; set; }
            public string StatusDostave { get; set; }
            //public string Status
            //{
            //    get
            //    {
            //        return _statusDescription;
            //    }
            //    set
            //    {

            //    }
            //}
            public string Opis { get; set; }
            public DateTime DatumIzmjene { get; set; }
            public int DostavaId { get; set; }
        }
    }
}
