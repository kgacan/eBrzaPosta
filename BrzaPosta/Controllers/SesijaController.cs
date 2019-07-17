using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.EF;
using BrzaPosta.Web.EntityModels;
using BrzaPosta.Web.Helper;
using BrzaPosta.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrzaPosta.Web.Controllers
{
        [Autorizacija(admin:true, user:true, zaposlenik:true)]
        public class SesijaController : Controller
        {
            private BrzaPostaDbContext _db;

            public SesijaController(BrzaPostaDbContext db)
            {
                _db = db;
            }



        public IActionResult Index(string keyword)
        {

            List<AutorizacijskiToken> listaSesija = _db.autorizacijskiToken
                .Include(a => a.KorisnickiNalog).ToList();

            SesijaIndexVM model = new SesijaIndexVM();

            if (keyword != null)
            {

                model.Rows = listaSesija
                .Where(x => x.KorisnickiNalog.Username.StartsWith(keyword))
                    .Select(s => new SesijaIndexVM.Row
                    {
                        VrijemeLogiranja = s.VrijemeEvidentiranja,
                        token = s.Vrijednost,
                        IpAdresa = s.IpAdresa,
                        username = s.KorisnickiNalog.Username
                    }).ToList();

            }
            else
            {
                model.Rows = listaSesija.Select(s => new SesijaIndexVM.Row
                {
                    VrijemeLogiranja = s.VrijemeEvidentiranja,
                    token = s.Vrijednost,
                    IpAdresa = s.IpAdresa,
                    username = s.KorisnickiNalog.Username
                }).ToList();    
    
            }

            model.TrenutniToken = HttpContext.GetTrenutniToken();

            return PartialView(model);
        }
            
            public IActionResult Prikazi()
            {
                return View();
            }



            public IActionResult Obrisi(string token)
            {
                AutorizacijskiToken obrisati = _db.autorizacijskiToken.FirstOrDefault(x => x.Vrijednost == token);
                if (obrisati != null)
                {
                    _db.autorizacijskiToken.Remove(obrisati);
                    _db.SaveChanges();
                }
                return RedirectToAction(nameof(Prikazi));
            }
        }
    }