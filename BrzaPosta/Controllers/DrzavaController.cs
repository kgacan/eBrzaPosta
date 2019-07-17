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
using static BrzaPosta.ViewModels.DrzavaPrikaziVM;

namespace BrzaPosta.Controllers
{
    [Autorizacija(admin: true, user: false, zaposlenik: true)]
    public class DrzavaController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public DrzavaController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        public IActionResult Prikazi(int? RegionIdZaSelect)
        {
            DrzavaPrikaziVM model = new DrzavaPrikaziVM();
            model.podaciZaHtml = db.drzave.Where(x=> !RegionIdZaSelect.HasValue || x.RegionId==RegionIdZaSelect).Select(d => new DrzavaVM
            {
                DrzavaId = d.DrzavaId,
                Naziv = d.Naziv,
                RegionId = d.RegionId, 
                Region_Naziv = d.Region.Naziv
            }).ToList();

            model.RegioniZaSelectTag = new List<SelectListItem>();
            model.RegioniZaSelectTag.Add(new SelectListItem { Value = null, Text = "(sve regije)" });
            model.RegioniZaSelectTag.AddRange(db.regioni.Select(r => new SelectListItem { Text = r.Naziv, Value = r.RegionId.ToString() }).ToList());

            return View(model);
        }
        public IActionResult Detalji(int Id)
        {
            Drzava dr = db.drzave.Where(x => x.DrzavaId == Id)
                .Include(y=>y.Region)
                .FirstOrDefault();

            DrzavaVM model = new DrzavaVM
            {
                DrzavaId=dr.DrzavaId,
                Naziv=dr.Naziv,
                RegionId=dr.RegionId,
                Region_Naziv=dr.Region.Naziv
            };
            return View(nameof(Detalji),model);
        }

        public IActionResult UrediForm(int Id)
        {
            DrzavaUrediVM model = new DrzavaUrediVM();
            
            if (Id != 0)
            {
                Drzava d = db.drzave.Find(Id);
                model.DrzavaId = d.DrzavaId;
                model.Naziv = d.Naziv;
                model.RegionId = d.RegionId;
            }

            model.regioniZaHTML = db.regioni.Select(r => new SelectListItem(r.Naziv, r.RegionId.ToString())).ToList();

            return PartialView(nameof(UrediForm), model);
        }
        public IActionResult Snimi(DrzavaUrediVM input)
        {
            if (!ModelState.IsValid)
            {
                input.regioniZaHTML = db.regioni.Select(r => new SelectListItem(r.Naziv, r.RegionId.ToString())).ToList();
                return View(nameof(UrediForm), input);
            }
            Drzava d;
            if(input.DrzavaId == 0)
            {
                d = new Drzava();
                db.Add(d);
                TempData["poruka-success"] = "Uspjesno dodavanje nove drzave";
            }
            else
            {
                d = db.drzave.Find(input.DrzavaId);
                TempData["poruka-success"] = "Uspjesno izmjena drzave";
            }
            d.Naziv = input.Naziv;
            d.RegionId = input.RegionId;

            db.SaveChanges();
            db.Dispose();

            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Obrisi(int Id)
        {
            Drzava d = db.drzave.Find(Id);
            if (d != null)
            {
                db.Remove(d);
                db.SaveChanges();
                db.Dispose();
                TempData["poruka-success"] = "Uspjesno obrisana drzava";
            }
            else
            {
                TempData["poruka-error"] = "Drzava nije pronadjen";
            }

            return RedirectToAction(nameof(Prikazi));
        }

    }
}