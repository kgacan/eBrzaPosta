#pragma checksum "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4fdeabe1c1c161edb6a9048c584aa38078ca443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registracija_Index), @"mvc.1.0.view", @"/Views/Registracija/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registracija/Index.cshtml", typeof(AspNetCore.Views_Registracija_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fdeabe1c1c161edb6a9048c584aa38078ca443", @"/Views/Registracija/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad51cb348a18d650f8d844709281a49f67ee662", @"/Views/_ViewImports.cshtml")]
    public class Views_Registracija_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrzaPosta.EntityModels.Zaposlenik>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
  
    ViewBag.Title = "Brza Posta - registracija";

#line default
#line hidden
            BeginContext(99, 52, true);
            WriteLiteral("\r\n<div>\r\n    <br />\r\n\r\n    <h3>Registracija</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
     using (Html.BeginForm("Registruj", "Registracija"))
    {
        

#line default
#line hidden
            BeginContext(225, 30, false);
#line 13 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
   Write(Html.LabelFor(n => n.Username));

#line default
#line hidden
            EndContext();
#line 13 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
                                       ; 

#line default
#line hidden
            BeginContext(258, 32, false);
#line 13 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
                                    Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
            EndContext();
#line 13 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
                                                                          ;

#line default
#line hidden
            BeginContext(291, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(309, 30, false);
#line 14 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
   Write(Html.LabelFor(n => n.Password));

#line default
#line hidden
            EndContext();
#line 14 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
                                       ; 

#line default
#line hidden
            BeginContext(342, 32, false);
#line 14 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
                                    Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
            EndContext();
#line 14 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
                                                                          ;

#line default
#line hidden
            BeginContext(375, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(386, 69, true);
            WriteLiteral("        <input type=\"submit\" value=\"Registruj\" id=\"btnRegistruj\" />\r\n");
            EndContext();
#line 17 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Registracija\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(462, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrzaPosta.EntityModels.Zaposlenik> Html { get; private set; }
    }
}
#pragma warning restore 1591