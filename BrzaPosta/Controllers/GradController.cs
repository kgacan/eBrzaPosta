using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using BrzaPosta.ViewModels;
using BrzaPosta.Web.Helper;
using Microsoft.AspNetCore.Mvc;

namespace BrzaPosta.Controllers
{
    [Autorizacija(admin: true, user: false, zaposlenik: true)]
    public class GradController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public GradController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        public IActionResult Index(int DrzavaId)
        {

            GradIndexVM model = new GradIndexVM
            {
                drzavaId=DrzavaId,
                gradoviZaHtml = db.gradovi.Where(x => x.DrzavaId == DrzavaId).Select(y=>new GradIndexVM.Row {
                    GradId=y.GradId,
                    Naziv=y.Naziv
                }).ToList()
            };

            return PartialView(nameof(Index),model);
        }
        public IActionResult Dodaj(int DrzavaId)
        {
            GradDodajVM model = new GradDodajVM();
            model.drzavaId = DrzavaId;

            return PartialView(nameof(Dodaj),model);
        }
        public IActionResult Snimi(GradDodajVM input)
        {

            if (!ModelState.IsValid)
            {
                return PartialView(nameof(Dodaj), input);
            }
            Grad g;
            if (input.gradId == 0)
            {
                g = new Grad();
                db.gradovi.Add(g);
                TempData["poruka-success"] = "Uspjesno dodavanje novog grada";
            }
            else
            {
                g = db.gradovi.Find(input.gradId);
                TempData["poruka-success"] = "Uspjesna izmjena grada";
            }
            g.DrzavaId = input.drzavaId;
            g.Naziv = input.naziv;
            db.SaveChanges();
            return Redirect("/Drzava/Detalji?Id=" + input.drzavaId);
        }
        public IActionResult Brisi(int Id)
        {
            
            Grad g = db.gradovi.Find(Id);
            int drzavaId = g.DrzavaId;
            db.Remove(g);
            db.SaveChanges();

            TempData["poruka-success"] = "Uspjesno brisanje grada";
            return Redirect("/Drzava/Detalji?Id=" + drzavaId);

            //return Redirect("/Grad/Index?DrzavaId=" + drzavaId);
        }
        public IActionResult Uredi(int Id)
        {
            Grad g = db.gradovi.Find(Id);
            GradDodajVM model = new GradDodajVM
            {
                drzavaId=g.DrzavaId,
                gradId=g.GradId,
                naziv=g.Naziv
            };

            return PartialView(nameof(Dodaj), model);
        }
    }
}
