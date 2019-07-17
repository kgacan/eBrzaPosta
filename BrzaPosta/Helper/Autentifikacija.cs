using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using BrzaPosta.Web.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace BrzaPosta.Web.Helper
{
    public static class Autentifikacija
    {
        private const string LogiraniKorisnik = "logirani_korisnik";

        public static void SetLogiraniKorisnik(this HttpContext context, KorisnickiNalog korisnik, bool snimiUCookie = false)
        {

            //context.Session.Set(LogiraniKorisnik, korisnik);

            //if (snimiUCookie)
            //{
            //    context.Response.SetCookieJson(LogiraniKorisnik, korisnik);
            //}
            //else
            //{
            //    context.Response.SetCookieJson(LogiraniKorisnik, null);
            //}

            BrzaPostaDbContext db = context.RequestServices.GetService<BrzaPostaDbContext>();

            string stariToken = context.Request.GetCookieJson<string>(LogiraniKorisnik);
            if (stariToken != null)
            {
                AutorizacijskiToken obrisati = db.autorizacijskiToken.FirstOrDefault(x => x.Vrijednost == stariToken);
                if (obrisati != null)
                {
                    db.autorizacijskiToken.Remove(obrisati);
                    db.SaveChanges();
                }
            }

            if (korisnik != null)
            {

                string token = Guid.NewGuid().ToString();
                db.autorizacijskiToken.Add(new AutorizacijskiToken
                {
                    Vrijednost = token,
                    KorisnickiNalogId = korisnik.korisnickiNalogId,
                    VrijemeEvidentiranja = DateTime.Now
                });
                db.SaveChanges();
                context.Response.SetCookieJson(LogiraniKorisnik, token);

            }

            context.Session.Set(LogiraniKorisnik, korisnik);

            //if (snimiUCookie)
            //{
            //    BrzaPostaDbContext db = context.RequestServices.GetService<BrzaPostaDbContext>();

            //    string token = Guid.NewGuid().ToString();
            //    db.autorizacijskiToken.Add(new AutorizacijskiToken
            //    {
            //        Vrijednost=token,
            //        KorisnickiNalogId=korisnik.korisnickiNalogId,
            //        VrijemeEvidentiranja=DateTime.Now
            //    });
            //    db.SaveChanges();
            //    context.Response.SetCookieJson(LogiraniKorisnik, token);
            //}

            //else
            //    context.Response.SetCookieJson(LogiraniKorisnik, null);
        }

        public static string GetTrenutniToken(this HttpContext context)
        {
            return context.Request.GetCookieJson<string>(LogiraniKorisnik);
        }

        public static KorisnickiNalog GetLogiraniKorisnik(this HttpContext context)
        {

            ////////KorisnickiNalog korisnik = context.Session.Get<KorisnickiNalog>(LogiraniKorisnik);
            ////////if(korisnik == null)
            ////////{
            ////////    korisnik = context.Request.GetCookieJson<KorisnickiNalog>(LogiraniKorisnik);
            ////////    context.Session.Set(LogiraniKorisnik, korisnik);
            ////////}
            ////////return korisnik;

            //BrzaPostaDbContext db = context.RequestServices.GetService<BrzaPostaDbContext>();

            //string token = context.Request.GetCookieJson<string>(LogiraniKorisnik);
            //if (token == null)
            //    return null;

            //return db.autorizacijskiToken
            //    .Where(x => x.Vrijednost == token)
            //    .Select(s => s.KorisnickiNalog)
            //    .SingleOrDefault();

            KorisnickiNalog korisnik = context.Session.Get<KorisnickiNalog>(LogiraniKorisnik);

            if (korisnik == null)
            {
                BrzaPostaDbContext db = context.RequestServices.GetService<BrzaPostaDbContext>();

                string token = context.Request.GetCookieJson<string>(LogiraniKorisnik);
                if (token == null)
                {
                    return null;
                }
                AutorizacijskiToken autorizacijskiToken = db.autorizacijskiToken
                    .Include(x => x.KorisnickiNalog)
                    .SingleOrDefault(x => x.Vrijednost == token);

                if (autorizacijskiToken != null)
                {
                    context.Session.Set(LogiraniKorisnik, autorizacijskiToken.KorisnickiNalog);
                }

            }

            return korisnik;

        }
    }
}
