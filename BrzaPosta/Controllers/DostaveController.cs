using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BrzaPosta.EF;
using BrzaPosta.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using BrzaPosta.EntityModels;
using BrzaPosta.Web.Helper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ReflectionIT.Mvc.Paging;

namespace BrzaPosta.Controllers
{
    public class DostaveController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public DostaveController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        [Autorizacija(user: false, admin: false, zaposlenik: true)]
        public IActionResult Index(int page=1)
        {

            //HITNE DOSTAVE

            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Index", "Autentifikacija");
            }

            Zaposlenik zaposlenik = db.zaposlenici.Where(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId).FirstOrDefault();

            var query = db.dostave
                .Where(x => x.Aktivna == true && x.Prioritet <= 1 && x.DostavljacId == zaposlenik.ZaposlenikId).Select(y => new HitneDostaveVM
                {
                    DatumDostave = y.DatumDostave.ToShortDateString(),
                    DostavaId = y.DostavaId,
                    brojDostave = y.BrojDostave
                }).AsNoTracking().OrderBy(x => x.DatumDostave);

            var model = PagingList.Create(query, 5, page);

            return View("HitneDostave", model);

        }


        [Autorizacija(user: false, admin: false, zaposlenik: true)]
        public IActionResult ArhivaDostava()
        {
            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Index", "Autentifikacija");
            }
            Zaposlenik zaposlenik = db.zaposlenici.Where(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId).FirstOrDefault();



            List<int> lista_ID_DostavaNaCekanju = db.statusi.GroupBy(a => a.DostavaId).Where(q => q.Count(w => w.StatusDostave == "Dostavljena") >= 1
                && q.Select(s => s.Dostava.Dostavljac.ZaposlenikId == zaposlenik.ZaposlenikId).FirstOrDefault())
                .Select(y => y.Key).ToList();

            DostavaIndexVM model = new DostavaIndexVM(); 

            List<Dostava> listaDostaNaCekanju = new List<Dostava>();

            for (int i = 0; i < lista_ID_DostavaNaCekanju.Count(); i++)
            {
                listaDostaNaCekanju.Add(db.dostave.Where(x => x.DostavaId == lista_ID_DostavaNaCekanju[i])
                       .Include(a => a.Dostavljac)
                       .Include(a => a.Platilac)
                       .Include(a => a.Posiljalac)
                       .Include(a => a.Primalac)
                       .FirstOrDefault());
            }

            model.dostaveZaHtml = new List<DostavaIndexVM.DostavaVM>();
            model.dostaveZaHtml.AddRange(listaDostaNaCekanju.Select(y => new DostavaIndexVM.DostavaVM
            {
                DostavaId = y.DostavaId,
                Dostavljac = y.Dostavljac.Ime + " " + y.Dostavljac.Prezime,
                Platilac = y.Platilac.Ime + " " + y.Platilac.Prezime,
                Posiljalac = y.Posiljalac.Ime + " " + y.Posiljalac.Prezime,
                Primalac = y.Primalac.Ime + " " + y.Primalac.Prezime
            }));
            model.brojDostava = listaDostaNaCekanju.Count();

            return View(nameof(ArhivaDostava), model);

        }



        [Autorizacija(user: false, admin: false, zaposlenik: true)]
        public IActionResult DostaveNaCekanju()
        {
            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Index", "Autentifikacija");
            }
            Zaposlenik zaposlenik = db.zaposlenici.Where(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId).FirstOrDefault();

            List<int> lista_ID_DostavaNaCekanju = db.statusi.GroupBy(a => a.DostavaId).Where(q => q.Count(w => w.StatusDostave == "Dostavljena") == 0 
                && q.Select(s=>s.Dostava.Dostavljac.ZaposlenikId==zaposlenik.ZaposlenikId).FirstOrDefault())
                .Select(y => y.Key).ToList();

            DostavaIndexVM model = new DostavaIndexVM();

            List<Dostava> listaDostaNaCekanju = new List<Dostava>();

            for (int i = 0; i < lista_ID_DostavaNaCekanju.Count(); i++)
            {
                listaDostaNaCekanju.Add(db.dostave.Where(x => x.DostavaId == lista_ID_DostavaNaCekanju[i])
                       .Include(a => a.Dostavljac)
                       .Include(a => a.Platilac)
                       .Include(a => a.Posiljalac)
                       .Include(a => a.Primalac)
                       .FirstOrDefault());
            }

            model.dostaveZaHtml = new List<DostavaIndexVM.DostavaVM>();
            model.dostaveZaHtml.AddRange(listaDostaNaCekanju.Select(y => new DostavaIndexVM.DostavaVM
            {
                DostavaId = y.DostavaId,
                Dostavljac = y.Dostavljac.Ime + " " + y.Dostavljac.Prezime,
                Platilac = y.Platilac.Ime + " " + y.Platilac.Prezime,
                Posiljalac = y.Posiljalac.Ime + " " + y.Posiljalac.Prezime,
                Primalac = y.Primalac.Ime + " " + y.Primalac.Prezime
            }));
            model.brojDostava = listaDostaNaCekanju.Count();

            return View(nameof(DostaveNaCekanju), model);
        }



        [Autorizacija(user: false, admin: false, zaposlenik: true)]
        public IActionResult ZavrsiDostavu()
        {
            return RedirectToAction(nameof(DostaveNaCekanju));
        }



        [Autorizacija(user: false, admin: false, zaposlenik: true)]
        public IActionResult Zavrsi(int DostavaID)
        {
            Dostava d = db.dostave.Where(x => x.DostavaId == DostavaID).FirstOrDefault();
            var model = new DostaveZavrsiVM
            {
                DatumStatusa = DateTime.Now,
                DostavaId = d.DostavaId,
                //status
            };

            return PartialView(model);
        }

        public IActionResult ZavrsiSnimiDostavu(DostaveZavrsiVM vm)
        {
            Dostava d = db.dostave.Find(vm.DostavaId);

            if(vm.status == Enums.Status.Dostavljena)
                d.Aktivna = false;

            Status s = new Status
            {
                DatumIzmjene = vm.DatumStatusa,
                DostavaId = vm.DostavaId,
                Opis = vm.Opis,
                StatusDostave = vm.status.ToString()
            };

            db.Add(s);
            db.SaveChanges();

            return RedirectToAction(nameof(DostaveNaCekanju));
            
        }


        public IActionResult Dodaj()
        {
            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Index", "Autentifikacija");
            }

            var korisnik = db.korisnici.Where(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId).FirstOrDefault();

            DostavaDodajVM model = new DostavaDodajVM();

            model.PosiljalacId = korisnik.KorisnikId;
            model.posiljalac = korisnik.Ime + " " + korisnik.Prezime;
            model.DatumKreiranja = DateTime.Now;

            model.dostavljaci = db.zaposlenici.Select(x => new SelectListItem
            {
                Value = x.ZaposlenikId.ToString(),
                Text = x.Ime
            }).ToList();

            model.korisnici = db.korisnici.Select(x => new SelectListItem
            {
                Value = x.KorisnikId.ToString(),
                Text = x.Ime
            }).ToList();

            model.adrese = db.adrese.Select(x => new SelectListItem
            {
                Text = x.Ulica,
                Value = x.AdresaId.ToString()
            }).ToList();

            return View(nameof(Dodaj), model);
        }


        public IActionResult Snimi(DostavaDodajVM input)
        {
            Dostava d = new Dostava
            {
                Aktivna = input.Aktivna,
                BrojDostave = input.BrojDostave,
                Cijena = input.Cijena,
                DatumDostave = input.DatumDostave,
                DatumIzmjene = input.DatumIzmjene,
                DatumKreiranja = input.DatumKreiranja,
                DostavaId = input.DostavaId,
                DostavljacId = input.DostavljacId,
                PlatilacId = input.PlatilacId,
                PosiljalacId = input.PosiljalacId,
                PrimalacId = input.PrimalacId,
                Prioritet = input.Prioritet,
                Tezina = input.Tezina,
                AdresaId=input.TrenutnaAdresaId
            };

            db.Add(d);
            db.SaveChanges();

            int dostava = db.dostave.Max(x => x.DostavaId);

            return Redirect("/StavkeDostave/Dodaj?DostavaID=" + dostava + "&PosiljalacID=" + input.PosiljalacId);
        }


        public IActionResult Detalji(int DostavaID)
        {
            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Index", "Autentifikacija");
            }

            bool IsDostavljac = false;
            if (db.zaposlenici.Any(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId))
                IsDostavljac = true;

            Dostava d = db.dostave.Where(x => x.DostavaId == DostavaID)
                .Include(a => a.Adresa)
                .ThenInclude(a=>a.Grad)
                .ThenInclude(a=>a.Drzava)
                .FirstOrDefault();

            DostaveDetaljiVM model = new DostaveDetaljiVM
            {
                DostavaID = d.DostavaId,
                BrojDostave = d.BrojDostave,
                Aktivna = d.Aktivna == true ? "DA" : "NE",
                Cijena = d.Cijena,
                DatumDostave = d.DatumDostave.ToShortDateString(),
                DatumIzmjene = d.DatumIzmjene.ToShortDateString(),
                DatumKreiranja = d.DatumKreiranja.ToShortDateString(),
                Prioritet = d.Prioritet,
                Tezina = d.Tezina,
                IsZaposlenik = IsDostavljac,
                MjestoDostavljanja = d.Adresa.Ulica + " " + d.Adresa.BrUlice + " " + d.Adresa.PostnskiBroj + " " + d.Adresa.Grad.Naziv + ", " + d.Adresa.Grad.Drzava.Naziv
            };

            return View(nameof(Detalji), model);
        }


        public IActionResult PretragaPosiljke()
        {
            return View();
        }


        public IActionResult PratiDostavu(string sifra)
        {
            Dostava dostava = new Dostava();
            if (db.dostave.Any(x => x.BrojDostave == sifra))
            {
                dostava = db.dostave.Where(x => x.BrojDostave == sifra)
                    .Include(a => a.Adresa).ThenInclude(a => a.Grad).ThenInclude(a => a.Drzava)
                    .Include(b => b.Dostavljac)
                    .FirstOrDefault();
            }

            PratiPosiljkuVM model = new PratiPosiljkuVM();

            model.dostavaId = dostava.DostavaId;
            model.Sifra = dostava.BrojDostave;
            if (model.Sifra != null)
            {
                model.Dostavljac = dostava.Dostavljac.Ime + " " + dostava.Dostavljac.Prezime;
                model.TrenutnaAdresa = dostava.Adresa.Ulica + " " +
                                 dostava.Adresa.BrUlice + " " +
                                 dostava.Adresa.Grad.Naziv + ", " +
                                 dostava.Adresa.Grad.Drzava.Naziv;

            }

            return PartialView(model);
        }
    }
}
