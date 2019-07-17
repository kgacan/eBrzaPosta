using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.Web.ViewModels
{
    public class StatusiIndexVM
    {
        public List<StatusiVM> listaStatusa { get; set; }
        public int dostavaId { get; set; }
        public class StatusiVM
        {
            private string _statusDostave;

            public int StatusId { get; set; }
            public string StatusDostave
            {
                get
                {
                    int status = -1;
                    Int32.TryParse(_statusDostave, out status);

                    switch(status)
                    {
                        case 1:
                            return "Kreirana";
                            break;
                        case 2:
                            return "Preuzeta";
                            break;
                        case 3:
                            return "U Tranzitu";
                            break;
                        case 4:
                            return "Dostavljena";
                            break;
                        default:
                            return "n/a";
                    }
                }
                set
                {
                    _statusDostave = value;
                }
            }
            public string Opis { get; set; }
            public DateTime DatumIzmjene { get; set; }
            public int DostavaId { get; set; }
        }

    }
}
