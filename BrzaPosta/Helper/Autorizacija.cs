using BrzaPosta.EF;
using BrzaPosta.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BrzaPosta.Web.Helper
{
    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute(bool user, bool admin, bool zaposlenik)
            : base(typeof(MyAuthorizeImpl))
        {
            Arguments = new object[] { user, admin, zaposlenik };
        }
    }


    public class MyAuthorizeImpl : IAsyncActionFilter
    {
        public MyAuthorizeImpl(bool user, bool admin, bool zaposlenik)
        {
            _user = user;
            _admin = admin;
            _zaposlenik = zaposlenik;
        }
        private readonly bool _user;
        private readonly bool _admin;
        private readonly bool _zaposlenik;
        public async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            KorisnickiNalog k = filterContext.HttpContext.GetLogiraniKorisnik();

            if (k == null)
            {
                if (filterContext.Controller is Controller controller)
                {
                    controller.TempData["error_poruka"] = "Niste logirani";
                }

                filterContext.Result = new RedirectToActionResult("Index", "Home", new { @area = "" });
                return;
            }

            //Preuzimamo DbContext preko app services
            BrzaPostaDbContext db = filterContext.HttpContext.RequestServices.GetService<BrzaPostaDbContext>();

            //useri mogu pristupiti 
            if (_user && db.korisnici.Any(s => s.AktivacijaId == k.korisnickiNalogId))
            {
                await next(); //ok - ima pravo pristupa
                return;
            }

            //admini mogu pristupiti
            if (_admin && db.administratori.Any(s => s.AktivacijaId == k.korisnickiNalogId))
            {
                await next();//ok - ima pravo pristupa
                return;
            }
            //zaposlenici mogu pristupiti
            if (_zaposlenik && db.zaposlenici.Any(s => s.AktivacijaId == k.korisnickiNalogId))
            {
                await next();//ok - ima pravo pristupa
                return;
            }


            if (filterContext.Controller is Controller c1)
            {
                c1.ViewData["error_poruka"] = "Nemate pravo pristupa";
            }
            filterContext.Result = new RedirectToActionResult("Index", "Home", new { @area = "" });
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // throw new NotImplementedException();
        }
    }
}
