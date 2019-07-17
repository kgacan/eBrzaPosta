using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using BrzaPosta.Web.Helper;
using BrzaPosta.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace BrzaPosta.Controllers
{
    [Autorizacija(admin: true, user: false, zaposlenik:true)]
    public class RegionController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public RegionController(BrzaPostaDbContext baza)
        {
            db = baza;
        }
        public IActionResult Index(int page = 1)
        {
            KorisnickiNalog korisnik = HttpContext.GetLogiraniKorisnik();
            if (korisnik == null)
            {
                TempData["error_poruka"] = "Nemate pravo pristupa";
                return RedirectToAction("Index", "Autentifikacija");
            }

            var query = db.regioni.Select(x=> new RegionIndexVM {
                Id=x.RegionId,
                Naziv=x.Naziv
            }).AsNoTracking().OrderBy(x => x.Naziv);

            var model = PagingList.Create(query, 5, page);

            return View("Prikazi", model);
        }


        public IActionResult UrediForm(int Id)
        {
            Region model;
            if(Id == 0)
            {
                model = new Region();
            }
            else
            {
                model = db.regioni.Find(Id);
            }
            return PartialView(nameof(UrediForm), model);
        }


        public IActionResult SnimiForm(Region input)
        {

            Region region;
            if (input.RegionId == 0)
            {
                region = new Region();
                db.Add(region);
                TempData["poruka-success"] = "Uspjesno dodavanje regiona";
            }
            else
            {
                region = db.regioni.Find(input.RegionId);
                TempData["poruka-success"] = "Uspjesna izmjena regiona";
            }

            region.Naziv = input.Naziv;

            db.SaveChanges();

            db.Dispose();

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Obrisi(int Id)
        {
            Region r = db.regioni.Find(Id);
            if(r != null)
            {
                db.Remove(r);
                db.SaveChanges();
                db.Dispose();
                TempData["poruka-success"] = "Uspjesno obrisan region";
            }
            else
            {
                TempData["poruka-error"] = "Region nije pronadjen";
            }
           
            return RedirectToAction(nameof(Index));
        }
    }
}