#pragma checksum "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d362ecfad4ae0d5b534fb42d4abf0d11c9b326dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grad_Index), @"mvc.1.0.view", @"/Views/Grad/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grad/Index.cshtml", typeof(AspNetCore.Views_Grad_Index))]
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
#line 2 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
using BrzaPosta.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d362ecfad4ae0d5b534fb42d4abf0d11c9b326dd", @"/Views/Grad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad51cb348a18d650f8d844709281a49f67ee662", @"/Views/_ViewImports.cshtml")]
    public class Views_Grad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GradIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
  
    string porukaSuccess = TempData["poruka-success"] as string;
    int brojac = 1;

#line default
#line hidden
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
 if (porukaSuccess != null)
{

#line default
#line hidden
            BeginContext(183, 88, true);
            WriteLiteral("    <div class=\"alert alert-dismissible alert-success\" id=\"porukaBox\">\r\n        <strong>");
            EndContext();
            BeginContext(272, 13, false);
#line 14 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
           Write(porukaSuccess);

#line default
#line hidden
            EndContext();
            BeginContext(285, 23, true);
            WriteLiteral("</strong>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
}

#line default
#line hidden
            BeginContext(311, 250, true);
            WriteLiteral("\r\n<table class=\"table table-hover table-light\" style=\"margin:5px 0;\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\" colspan=\"3\">Gradovi</th>\r\n        </tr>\r\n    </thead>\r\n</table>\r\n<table class=\"table table-hover table-light\">\r\n   <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
         foreach (GradIndexVM.Row x in Model.gradoviZaHtml)
        {

#line default
#line hidden
            BeginContext(633, 57, true);
            WriteLiteral("            <tr class=\"table-dark\">\r\n                <td>");
            EndContext();
            BeginContext(692, 8, false);
#line 30 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
                Write(brojac++);

#line default
#line hidden
            EndContext();
            BeginContext(701, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(729, 7, false);
#line 31 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
               Write(x.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(736, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 787, "\"", 826, 2);
            WriteAttributeValue("", 794, "/Adresa/Prikazi?GradID=", 794, 23, true);
#line 33 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
WriteAttributeValue("", 817, x.GradId, 817, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(827, 123, true);
            WriteLiteral(" class=\"btn btn-outline-info\"><i class=\"fas fa-location-arrow\"></i> Adrese</a>\r\n                    <button ajax-poziv=\"da\"");
            EndContext();
            BeginWriteAttribute("ajax-url", " ajax-url=\"", 950, "\"", 985, 2);
            WriteAttributeValue("", 961, "/Grad/Uredi?Id=", 961, 15, true);
#line 34 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
WriteAttributeValue("", 976, x.GradId, 976, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(986, 141, true);
            WriteLiteral(" ajax-rez=\"content\" class=\"btn btn-outline-secondary\"><i class=\"far fa-edit\"></i> Uredi</button>\r\n                    <button ajax-poziv=\"da\"");
            EndContext();
            BeginWriteAttribute("ajax-url", " ajax-url=\"", 1127, "\"", 1162, 2);
            WriteAttributeValue("", 1138, "/Grad/Brisi?Id=", 1138, 15, true);
#line 35 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
WriteAttributeValue("", 1153, x.GradId, 1153, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1163, 143, true);
            WriteLiteral(" ajax-rez=\"content\" class=\"btn btn-outline-warning\"><i class=\"far fa-trash-alt\"></i> Brisi</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1317, 49, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n<button ajax-poziv=\"da\"");
            EndContext();
            BeginWriteAttribute("ajax-url", " ajax-url=\"", 1366, "\"", 1413, 2);
            WriteAttributeValue("", 1377, "/Grad/Dodaj?DrzavaId=", 1377, 21, true);
#line 42 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Grad\Index.cshtml"
WriteAttributeValue("", 1398, Model.drzavaId, 1398, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1414, 103, true);
            WriteLiteral(" ajax-rez=\"content\" class=\"btn btn-outline-primary btn-lg\"><i class=\"fas fa-plus\"></i> Dodaj</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GradIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
