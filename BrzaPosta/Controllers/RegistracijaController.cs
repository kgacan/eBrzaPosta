using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using Microsoft.AspNetCore.Mvc;

namespace BrzaPosta.Controllers
{
    public class RegistracijaController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public RegistracijaController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        public IActionResult Index()
        {
            EntityModels.Zaposlenik admin = new EntityModels.Zaposlenik();
            return View(admin);
        }

        public ActionResult Registruj(EntityModels.Zaposlenik admin)
        {
            admin.Ime = string.Empty;
            admin.Prezime = string.Empty;
            admin.Aktivan = true;
            admin.Email = string.Format("{0}@brzaposta.com", admin.Username);

            db.zaposlenici.Add(admin);

            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}