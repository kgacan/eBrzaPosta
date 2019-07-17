using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrzaPosta.Models;
using BrzaPosta.Web.Helper;
using BrzaPosta.EntityModels;
using BrzaPosta.EF;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BrzaPosta.Controllers
{
    public class HomeController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public HomeController(BrzaPostaDbContext baza)
        {
            db = baza;
        }
        public IActionResult Index()
        {
            KorisnickiNalog korisnickiNalog = HttpContext.GetLogiraniKorisnik();
            if (korisnickiNalog == null)
            {
                TempData["error_poruka"] = "Niste logirani";
                return RedirectToAction("Pocetna", "Autentifikacija");
            }

            if (db.administratori.Where(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId).Any())
            {
                return View("AdminIndex");
            }


            if (db.zaposlenici.Where(x => x.AktivacijaId == korisnickiNalog.korisnickiNalogId).Any())
            {
                return View("ZaposlenikIndex");
            }

            return View("UserIndex");
            
        }
    }
}
