#pragma checksum "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3da9babdf1d87dd90a45c182c87922ab283faa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dostave_PratiDostavu), @"mvc.1.0.view", @"/Views/Dostave/PratiDostavu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dostave/PratiDostavu.cshtml", typeof(AspNetCore.Views_Dostave_PratiDostavu))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\_ViewImports.cshtml"
using BrzaPosta;

#line default
#line hidden
#line 2 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\_ViewImports.cshtml"
using BrzaPosta.Models;

#line default
#line hidden
#line 3 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\_ViewImports.cshtml"
using BrzaPosta.Web.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3da9babdf1d87dd90a45c182c87922ab283faa2", @"/Views/Dostave/PratiDostavu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad51cb348a18d650f8d844709281a49f67ee662", @"/Views/_ViewImports.cshtml")]
    public class Views_Dostave_PratiDostavu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PratiPosiljkuVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml"
 if(Model.Sifra == null)
{

#line default
#line hidden
            BeginContext(55, 168, true);
            WriteLiteral("    <div class=\"nadjenaPosiljka\">\r\n        <span><b>Nažalost, tražena pošiljka nije pronađena. Provjerite ispravnost unosa vaše šifre pošiljke!</b></span>\r\n    </div>\r\n");
            EndContext();
#line 8 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(235, 184, true);
            WriteLiteral("    <div class=\"nadjenaPosiljka\">\r\n        \r\n            <table>\r\n                <tr>\r\n                    <td style=\" padding-right:7px;\"><b>Šifra:</b></td>\r\n                    <td>");
            EndContext();
            BeginContext(420, 11, false);
#line 16 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml"
                   Write(Model.Sifra);

#line default
#line hidden
            EndContext();
            BeginContext(431, 153, true);
            WriteLiteral("</td> \r\n                </tr>\r\n                <tr>\r\n                    <td style=\" padding-right:7px\"><b>Dostavljač:</b></td>\r\n                    <td>");
            EndContext();
            BeginContext(585, 16, false);
#line 20 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml"
                   Write(Model.Dostavljac);

#line default
#line hidden
            EndContext();
            BeginContext(601, 168, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td style=\"padding-right:7px;\"><b>Trenutna lokacija pošiljke:</b></td>\r\n                    <td>");
            EndContext();
            BeginContext(770, 20, false);
#line 24 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml"
                   Write(Model.TrenutnaAdresa);

#line default
#line hidden
            EndContext();
            BeginContext(790, 64, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Dostave\PratiDostavu.cshtml"
}

#line default
#line hidden
            BeginContext(857, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PratiPosiljkuVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
