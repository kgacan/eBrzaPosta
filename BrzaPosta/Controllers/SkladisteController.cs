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
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace BrzaPosta.Web.Controllers
{
    [Autorizacija(admin: true, user: false, zaposlenik: true)]
    public class SkladisteController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public SkladisteController(BrzaPostaDbContext baza)
        {
            db = baza;
        }
        public IActionResult Index(int page = 1)
        {
 

            var query = db.skladista.Select(x => new SkladistaIndexVM
            {
                SkladisteId = x.SkladisteId,
                Adresa = x.Adresa.Ulica + " " + x.Adresa.BrUlice,
                Naziv = x.Naziv,
                Opis = x.Opis
            }).AsNoTracking().OrderBy(x => x.Naziv);

            var model = PagingList.Create(query, 5, page);

            return View(nameof(Index),model);
        }
        public IActionResult Dodaj(int? GradId, int? SkladisteId)
        {
            SkladisteDodajVM model = new SkladisteDodajVM();

            if (SkladisteId != 0 && SkladisteId != null)
            {
                Skladiste s = db.skladista.Find(SkladisteId);
                Adresa adr = db.adrese
                    .Include(y => y.Grad)
                    .Where(x => x.AdresaId == SkladisteId).FirstOrDefault();

                model.AdresaId = adr.AdresaId;
                model.GradId = adr.GradId;
                model.Naziv = s.Naziv;
                model.Opis = s.Opis;
                model.SkladisteId = (int)SkladisteId;
            }

            model.gradovi = db.gradovi.Select(x => new SelectListItem
            {
                Value = x.GradId.ToString(),
                Text = x.Naziv
            }).ToList();

            model.adrese = db.adrese.Where(y=>!GradId.HasValue || y.GradId==GradId).Select(x => new SelectListItem
            {
                Value = x.AdresaId.ToString(),
                Text = x.Ulica + " " + x.BrUlice
            }).ToList();


            return View(nameof(Dodaj), model);
        }
        public IActionResult Snimi(SkladisteDodajVM input)
        {
            Skladiste s = db.skladista.Find(input.SkladisteId);
            Skladiste s2 = new Skladiste();
            s2 = s;
            if (s == null)
            {
                if(db.skladista.Any(x => x.SkladisteId == input.AdresaId))
                {
                    TempData["poruka-danger"] = "Ova adresa je već zauzeta!Ne možete imati dva skladišta na istoj adresi!";
                    return RedirectToAction(nameof(Index));
                }
                s = new Skladiste();
                db.Add(s);
            }
            else
            {
                db.Remove(s);
                db.SaveChanges();
                if (db.skladista.Any(x => x.SkladisteId == input.AdresaId))
                {
                    db.Add(s2);
                    db.SaveChanges();
                    TempData["poruka-danger"] = "Ova adresa je već zauzeta!Ne možete imati dva skladišta na istoj adresi!";
                    return RedirectToAction(nameof(Index));
                }
                s = new Skladiste();
                db.Add(s);
            }
            s.SkladisteId = input.AdresaId;
            s.Naziv = input.Naziv;
            s.Opis = input.Opis;
            db.SaveChanges();
            TempData["poruka-success"] = "Uspješna dodavanje/izmjena novog skladišta";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Uredi(int SkladisteId)
        {
            Skladiste s = db.skladista.Find(SkladisteId);
            Adresa adr = db.adrese
                .Include(y=>y.Grad)
                .Where(x => x.AdresaId == SkladisteId).FirstOrDefault();
            SkladisteDodajVM model = new SkladisteDodajVM();
            model.adrese = db.adrese.Where(a => a.GradId == adr.GradId).Select(b => new SelectListItem
            {
                Value=b.AdresaId.ToString(), Text=b.Ulica+" "+b.BrUlice
            }).ToList();
            model.gradovi = db.gradovi.Select(c => new SelectListItem
            {
                Value = c.GradId.ToString(),
                Text = c.Naziv
            }).ToList();
            model.AdresaId = adr.AdresaId;
            model.GradId = adr.GradId;
            model.Naziv = s.Naziv;
            model.Opis = s.Opis;
            model.SkladisteId = SkladisteId;
            model.uredjivanje = true;

            return View(nameof(Dodaj), model);
        }

        public IActionResult Brisi(int SkladisteId)
        {
            Skladiste s = db.skladista.Find(SkladisteId);
            db.Remove(s);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }



        public IActionResult ProvjeriNaziv(string Naziv)
        {
          if (db.skladista.Any(x => x.Naziv == Naziv))
                return Json($"Naziv skladišta {Naziv} je zauzeto!");

            return Json(true);
        }
        public IActionResult ProvjeriAdresu(int AdresaId)
        {
            if (db.skladista.Any(x => x.SkladisteId == AdresaId))
                return Json($"Ova adresa je vec zauzeta! Ne mozete imati dva skladišta na istoj adresi!");

            return Json(true);
        }
    }
}