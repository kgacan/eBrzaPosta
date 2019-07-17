using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrzaPosta.EntityModels
{
    public class Dostava
    {
        [Key]
        public int DostavaId { get; set; }
        public DateTime DatumDostave { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public int Prioritet { get; set; }
        public bool Aktivna { get; set; }
        public string BrojDostave { get; set; }
        public double Tezina { get; set; }
        public double Cijena { get; set; }



        [ForeignKey("Dostavljac")]
        public int DostavljacId { get; set; }
        public Zaposlenik Dostavljac { get; set; }

        [ForeignKey("Posiljalac")]
        public int PosiljalacId { get; set; }
        public Korisnik Posiljalac { get; set; }

        [ForeignKey("Primalac")]
        public int PrimalacId { get; set; }
        public Korisnik Primalac { get; set; }

        [ForeignKey("Platilac")]
        public int PlatilacId { get; set; }
        public Korisnik Platilac { get; set; }

        [ForeignKey("Adresa")]
        public int AdresaId { get; set; }
        public Adresa Adresa { get; set; }
    }
}
