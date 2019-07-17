using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using BrzaPosta.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BrzaPosta.Web.Controllers
{
    public class StatusiController : Controller
    {
        private readonly BrzaPostaDbContext db;
        public StatusiController(BrzaPostaDbContext baza)
        {
            db = baza;
        }

        public IActionResult Index(int DostavaID)
        {
            StatusiIndexVM model = new StatusiIndexVM();
            model.dostavaId = DostavaID;
            model.listaStatusa = db.statusi.Where(x => x.DostavaId == DostavaID).Select(y => new StatusiIndexVM.StatusiVM
            {
                StatusId = y.StatusId,
                StatusDostave = y.StatusDostave,
                DatumIzmjene = y.DatumIzmjene,
                DostavaId = y.DostavaId,
                Opis = y.Opis
            }).ToList();

            return PartialView(nameof(Index), model);
        }

        public IActionResult DodajStatus(int DostavaID)
        {
            StatusiDodajVM status = new StatusiDodajVM();
            status.Status = new StatusiDodajVM.StatusiVM();
            status.Status.DostavaId = DostavaID;
            return View("DodajStatus", status);
        }

        public IActionResult Snimi(StatusiDodajVM input)
        {
            Status status = new Status
            {
                StatusDostave = input.Status.StatusDostave,
                Opis = input.Status.Opis,
                DatumIzmjene = DateTime.Now,
                DostavaId = input.Status.DostavaId
            };

            db.Add(status);
            db.SaveChanges();

            return Redirect("/Dostave/Detalji?DostavaID=" + status.DostavaId);
        }

        public IActionResult BrisiStatus(string statusid, string dostavaid)
        {
            db.statusi.Remove(db.statusi.First(s => s.StatusId == Convert.ToInt32(statusid)));
            db.SaveChanges();

            return Redirect("/Dostave/Detalji?DostavaID=" + dostavaid);
        }
    }
}