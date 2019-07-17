using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using BrzaPosta.ViewModels;
using BrzaPosta.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BrzaPosta.Controllers
{
    [Autorizacija(admin: true, user: false, zaposlenik: true)]
    public class AdresaController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public AdresaController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        public IActionResult Prikazi(int GradID)
        {
            AdresaPrikaziVM model = new AdresaPrikaziVM();

            model.GradID = GradID;
            model.Grad = db.gradovi.Where(x => x.GradId == GradID).Include(y => y.Drzava).FirstOrDefault();
            model.Drzava = db.drzave.Where(x => x.DrzavaId == model.Grad.DrzavaId).Include(y => y.Region).FirstOrDefault();

            return View(nameof(Prikazi),model);
        }
        public IActionResult Index(int GradID)
        {
            AdresaIndexVM model = new AdresaIndexVM();

            model.AdreseZaHtml = db.adrese.Where(x => x.GradId == GradID)
                .Select(a => new AdresaIndexVM.AdresaVM
                {
                    AdresaId = a.AdresaId,
                    Aktivna = a.Aktivna,
                    BrUlice = a.BrUlice,
                    PostnskiBroj = a.PostnskiBroj,
                    Ulica = a.Ulica

                }).ToList();
            model.GradID = GradID;

            return PartialView(nameof(Index), model);
        }
        public IActionResult Dodaj(int GradID)
        {
            AdresaDodajVM model = new AdresaDodajVM();
            model.GradId = GradID;

            return PartialView(nameof(Dodaj), model);
        }
        public IActionResult Dodaj2(int GradID, int SkladisteId)
        {
            AdresaDodajVM model = new AdresaDodajVM();
            model.GradId = GradID;
            model.SkladisteId = SkladisteId;

            return View(nameof(Dodaj2), model);
        }
        public IActionResult Uredi(int AdresaId)
        {
            Adresa a = db.adrese.Where(x => x.AdresaId == AdresaId).FirstOrDefault();
            AdresaDodajVM model = new AdresaDodajVM
            {
                AdresaId = a.AdresaId,
                Aktivna = a.Aktivna,
                BrUlice = a.BrUlice,
                GradId = a.GradId,
                PostnskiBroj = a.PostnskiBroj,
                Ulica = a.Ulica
            };

            return PartialView(nameof(Dodaj), model);
        }
        public IActionResult Snimi(AdresaDodajVM input)
        {
            Adresa adr;
            if (input.AdresaId == 0)
            {
                adr = new Adresa();
                db.Add(adr);
            }
            else
            {
                adr = db.adrese.Find(input.AdresaId);
            }
            adr.Aktivna = input.Aktivna;
            adr.BrUlice = input.BrUlice;
            adr.GradId = input.GradId;
            adr.PostnskiBroj = input.PostnskiBroj;
            adr.Ulica = input.Ulica;

            db.SaveChanges();
            db.Dispose();
            return Redirect("/Adresa/Prikazi?GradID=" + input.GradId);
        }
        public IActionResult Snimi2(AdresaDodajVM input)
        {
            Adresa adr;
            if (input.AdresaId == 0)
            {
                adr = new Adresa();
                db.Add(adr);
            }
            else
            {
                adr = db.adrese.Find(input.AdresaId);
            }
            adr.Aktivna = input.Aktivna;
            adr.BrUlice = input.BrUlice;
            adr.GradId = input.GradId;
            adr.PostnskiBroj = input.PostnskiBroj;
            adr.Ulica = input.Ulica;

            db.SaveChanges();
            db.Dispose();
            if (input.SkladisteId==0)
            {
                return Redirect("/Skladiste/Dodaj?GradID=" + input.GradId);
            }
            return Redirect("/Skladiste/Uredi?SkladisteId=" + input.SkladisteId);
        }
        public IActionResult Brisi(int AdresaId)
        {
            Adresa a = db.adrese.Find(AdresaId);
            int gradid = a.GradId;
            db.Remove(a);
            db.SaveChanges();
            db.Dispose();
            return Redirect("/Adresa/Prikazi?GradID=" + gradid);
        }
        //public List<SelectListItem> GetAdrese(int GradId)
        //{
        //    List<SelectListItem> adrese = db.adrese.Where(x => x.GradId == GradId).Select(y => new SelectListItem
        //    {
        //        Value=y.AdresaId.ToString(),
        //        Text=y.Ulica+" "+y.BrUlice
        //    }).ToList();
        //    return adrese;
        //}
    }

}