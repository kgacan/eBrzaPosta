#pragma checksum "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9084725e2c095b51df30ee33b3c43c7d2523ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StavkeDostave_Index), @"mvc.1.0.view", @"/Views/StavkeDostave/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StavkeDostave/Index.cshtml", typeof(AspNetCore.Views_StavkeDostave_Index))]
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
#line 1 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
using BrzaPosta.Web.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9084725e2c095b51df30ee33b3c43c7d2523ec", @"/Views/StavkeDostave/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad51cb348a18d650f8d844709281a49f67ee662", @"/Views/_ViewImports.cshtml")]
    public class Views_StavkeDostave_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StavkeDostaveIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Uredi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StavkeDostave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 36, true);
            WriteLiteral("\r\n<br/>\r\n<h5>STAVKE DOSTAVE</h5>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
  
    int b = 1;

#line default
#line hidden
            BeginContext(164, 291, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>R. br.</th>
            <th>Broj</th>
            <th>Naziv</th>
            <th>Opis</th>
            <th>Tezina</th>
            <th>Vrsta</th>
            <th>Akcije</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
         foreach (StavkeDostaveIndexVM.StavkeDostaveVM x in Model.listaStavkeDostave)
        {

#line default
#line hidden
            BeginContext(553, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(593, 3, false);
#line 31 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
                Write(b++);

#line default
#line hidden
            EndContext();
            BeginContext(597, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(625, 12, false);
#line 32 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
               Write(x.BrojStavke);

#line default
#line hidden
            EndContext();
            BeginContext(637, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(665, 7, false);
#line 33 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
               Write(x.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(672, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(700, 6, false);
#line 34 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
               Write(x.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(706, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(734, 8, false);
#line 35 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
               Write(x.Tezina);

#line default
#line hidden
            EndContext();
            BeginContext(742, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(770, 12, false);
#line 36 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
               Write(x.NazivVrste);

#line default
#line hidden
            EndContext();
            BeginContext(782, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(831, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a62347123aa74aceb6144afc2dddff08", async() => {
                BeginContext(951, 27, true);
                WriteLiteral("<i class=\"far fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-StavkaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
                                                                                 WriteLiteral(x.StavkaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StavkaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-StavkaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["StavkaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(982, 24, true);
            WriteLiteral("\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1056, 2);
            WriteAttributeValue("", 1013, "/StavkeDostave/Obrisi/?StavkaId=", 1013, 32, true);
#line 39 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
WriteAttributeValue("", 1045, x.StavkaId, 1045, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1057, 113, true);
            WriteLiteral(" class=\"btn btn-outline-warning\"><i class=\"far fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1181, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1295, 4);
            WriteAttributeValue("", 1214, "/StavkeDostave/Dodaj/?DostavaID=", 1214, 32, true);
#line 45 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
WriteAttributeValue("", 1246, Model.DostavaId, 1246, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1262, "&PosiljalacID=", 1262, 14, true);
#line 45 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\StavkeDostave\Index.cshtml"
WriteAttributeValue("", 1276, Model.PosiljalacId, 1276, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1296, 72, true);
            WriteLiteral(" class=\"btn btn-outline-primary\"><i class=\"fas fa-plus\"></i> Dodaj</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StavkeDostaveIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591