using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using BrzaPosta.Web.Helper;
using BrzaPosta.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BrzaPosta.Web.Controllers
{
    public class StavkeDostaveController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public StavkeDostaveController(BrzaPostaDbContext baza)
        {
            db = baza;
        }
        public IActionResult Index(int DostavaID)
        {
            StavkeDostaveIndexVM model = new StavkeDostaveIndexVM();
            model.DostavaId = DostavaID;
            model.PosiljalacId = db.dostave.Where(x => x.DostavaId == DostavaID).First().PosiljalacId;

            model.listaStavkeDostave = db.stavkeDostave.Where(x => x.DostavaId == DostavaID).Select(y => new StavkeDostaveIndexVM.StavkeDostaveVM
            {
                BrojStavke = y.BrojStavke,
                DostavaId = y.DostavaId,
                StavkaId = y.StavkaId,
                Naziv = y.Naziv,
                Opis = y.Opis,
                Tezina = y.Tezina,
                VrstaId = y.VrstaId,
                NazivVrste = y.Vrsta.Naziv
            }).ToList();

            return PartialView(nameof(Index), model);
        }

        public IActionResult Dodaj(int DostavaID)
        {
            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Index", "Autentifikacija");
            }

            StavkeDostaveDodajVM model = new StavkeDostaveDodajVM
            {
                PosiljalacID = korisnickiNalog.korisnickiNalogId,
                DostavaID = DostavaID,
                UkupnoDodanoStavki = db.stavkeDostave.Where(x => x.DostavaId == DostavaID).Count(),
                vrsteStavki = db.vrsteStavki.Select(x => new SelectListItem
                {
                    Value = x.VrstaId.ToString(),
                    Text = x.Naziv
                }).ToList()
            };

            return View(nameof(Dodaj), model);
        }

        public IActionResult Obrisi(int StavkaId)
        {
            StavkeDostave stavka = db.stavkeDostave.First(x => x.StavkaId == StavkaId);
            if (stavka != null)
                db.stavkeDostave.Remove(stavka);
            db.SaveChanges();

            return Redirect("/Dostave/Detalji?DostavaID=" + @stavka.DostavaId);
        }

        public IActionResult Uredi(int StavkaId)
        {
            StavkeDostave stavka = db.stavkeDostave.First(x => x.StavkaId == StavkaId);
            if (stavka == null)
                throw new ArgumentNullException("Greska prilikom ucitavanja stavke dostave!");

            StavkeDostaveDodajVM model = new StavkeDostaveDodajVM
            {
                StavkaId = stavka.StavkaId,
                Naziv = stavka.Naziv,
                Opis = stavka.Opis,
                Tezina = stavka.Tezina,
                VrstaId = stavka.VrstaId,
                //NazivVrste = stavka.Vrsta.Naziv,
                vrsteStavki = db.vrsteStavki.Select(i => new SelectListItem()
                {
                    Text = i.Naziv.ToString(),
                    Value = i.VrstaId.ToString()
                }).ToList()
            };

            return View(nameof(Uredi), model);
        }

        public IActionResult SnimiUredjenuStavku(StavkeDostaveDodajVM input)
        {
            StavkeDostave stavka = db.stavkeDostave.First(x => x.StavkaId == input.StavkaId);
            if (stavka == null)
                throw new ArgumentNullException("Greska prilikom snimanja stavke dostave!");

            stavka.Naziv = input.Naziv;
            stavka.Opis = input.Opis;
            stavka.Tezina = input.Tezina;
            stavka.VrstaId = input.VrstaId;

            db.SaveChanges();

            return Redirect("/Dostave/Detalji?DostavaID=" + @stavka.DostavaId);
        }

        public IActionResult Snimi(StavkeDostaveDodajVM input)
        {
            StavkeDostave sd = new StavkeDostave
            {
                BrojStavke = input.BrojStavke,
                DostavaId = input.DostavaID,
                Naziv = input.Naziv,
                Opis = input.Opis,
                Tezina = input.Tezina,
                VrstaId = input.VrstaId
            };
            db.Add(sd);
            //db.SaveChanges();

            Status s = new Status()
            {
                DostavaId = input.DostavaID,
                DatumIzmjene = DateTime.Now,
                Opis = "Dostava kreirana",
                StatusDostave = Helper.Enums.Status.Kreirana.ToString()
            };
            db.Add(s);
            db.SaveChanges();
            //db.Dispose();

            return Redirect("/Dostave/Index?PosiljalacID=" + input.PosiljalacID);
            //return Redirect("/Dostave/Detalji?DostavaID=" + input.DostavaID);

        }

        public IActionResult SnimiNovuStavku(StavkeDostaveDodajVM input)
        {
            StavkeDostave sd = new StavkeDostave
            {
                BrojStavke = input.BrojStavke,
                DostavaId = input.DostavaID,
                Naziv = input.Naziv,
                Opis = input.Opis,
                Tezina = input.Tezina,
                VrstaId = input.VrstaId
            };
            db.Add(sd);
            db.SaveChanges();
            //db.Dispose();

            return Redirect("/Dostave/Detalji?DostavaID=" + input.DostavaID);
            //return Redirect("/StavkeDostave/Dodaj?DostavaID=" + input.DostavaID + "&PosiljalacID=" + input.PosiljalacID);
        }
    }
}