using System.Linq;
using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using BrzaPosta.Web.Helper;
using BrzaPosta.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrzaPosta.Web.Controllers
{
    public class AutentifikacijaController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public AutentifikacijaController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        public IActionResult Index()
            {
                return View(new LoginVM()
                {
                    ZapamtiPassword = true,
                });
            }
        public IActionResult Pocetna()
        {
            return View();
        }

        public IActionResult Login(LoginVM input)
            {
                KorisnickiNalog korisnik = db.korisnickiNalog
                    .SingleOrDefault(x => x.Username == input.username && x.Password == input.password);

                if (korisnik == null)
                {
                    TempData["error_poruka"] = "pogrešan username ili password";
                    return View("Index", input);
                }

            HttpContext.SetLogiraniKorisnik(korisnik, input.ZapamtiPassword);

            return RedirectToAction("Index", "Home");
            }

            public IActionResult Logout()
            {
                return RedirectToAction("Index");
            }
    }
}