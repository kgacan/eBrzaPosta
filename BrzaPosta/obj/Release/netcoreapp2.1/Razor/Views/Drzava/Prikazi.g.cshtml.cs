#pragma checksum "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fc07f07a4b7351c584bdcb3ca15516720a4ff4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drzava_Prikazi), @"mvc.1.0.view", @"/Views/Drzava/Prikazi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Drzava/Prikazi.cshtml", typeof(AspNetCore.Views_Drzava_Prikazi))]
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
#line 1 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
using BrzaPosta.Controllers;

#line default
#line hidden
#line 2 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
using BrzaPosta.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7fc07f07a4b7351c584bdcb3ca15516720a4ff4", @"/Views/Drzava/Prikazi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad51cb348a18d650f8d844709281a49f67ee662", @"/Views/_ViewImports.cshtml")]
    public class Views_Drzava_Prikazi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrzavaPrikaziVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "RegionIdZaSelect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mr-sm-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-DostavaID", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/fast_delivery.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:45px; height:40px; padding:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
  
    ViewData["Title"] = "Prikazi";
    int brojac = 1;
    string porukaSuccess = TempData["poruka-success"] as string;

#line default
#line hidden
            BeginContext(213, 38, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"sadrzajDiv\">\r\n\r\n");
            EndContext();
#line 13 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
     if (porukaSuccess != null)
    {

#line default
#line hidden
            BeginContext(291, 168, true);
            WriteLiteral("        <div class=\"alert alert-dismissible alert-success\">\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n            <strong>");
            EndContext();
            BeginContext(460, 13, false);
#line 17 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
               Write(porukaSuccess);

#line default
#line hidden
            EndContext();
            BeginContext(473, 27, true);
            WriteLiteral("</strong>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
    }

#line default
#line hidden
            BeginContext(507, 186, true);
            WriteLiteral("    <a id=\"myBtn\" modal-poziv=\'da\' modalUrl=\"/Drzava/UrediForm\" class=\"btn btn-outline-primary btn-lg\" style=\"float:right; margin-bottom:5px;\"><i class=\"fas fa-plus\"></i> Dodaj</a>\r\n    ");
            EndContext();
            BeginContext(693, 593, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d511124829d42b489081da227accba8", async() => {
                BeginContext(699, 235, true);
                WriteLiteral("\r\n        <table class=\"table table-bordered table-light\" style=\"margin:5px 0;\">\r\n            <tbody>\r\n                <tr>\r\n                    <td><label for=\"RegionIdZaSelect\">Odaberite regiju:</label></td>\r\n                    <td>");
                EndContext();
                BeginContext(934, 134, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddd94b64335427e91663a24f38564f2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 26 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RegionIdZaSelect);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.RegioniZaSelectTag;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1068, 211, true);
                WriteLiteral("</td>\r\n                    <td><button type=\"submit\" class=\"btn btn-outline-primary\"><i class=\"fas fa-binoculars\"></i> Prikazi</button></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1286, 131, true);
            WriteLiteral("\r\n\r\n    <table class=\"table table-bordered table-hover\" style=\"margin:5px 0;\">\r\n        <tbody class=\"table-light table-hover\">\r\n\r\n");
            EndContext();
#line 37 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
             foreach (DrzavaPrikaziVM.DrzavaVM x in Model.podaciZaHtml)
            {

#line default
#line hidden
            BeginContext(1505, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1553, 8, false);
#line 40 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
                    Write(brojac++);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1594, 7, false);
#line 41 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1633, 14, false);
#line 42 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
                   Write(x.Region_Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1647, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
            BeginContext(2052, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2078, "\"", 2115, 2);
            WriteAttributeValue("", 2085, "/Drzava/Detalji?Id=", 2085, 19, true);
#line 48 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
WriteAttributeValue("", 2104, x.DrzavaId, 2104, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2116, 124, true);
            WriteLiteral(" class=\"btn btn-outline-info\"><i class=\"fas fa-info-circle\"></i></a>\r\n                        <a id=\"myBtn\" modal-poziv=\'da\'");
            EndContext();
            BeginWriteAttribute("modalUrl", " modalUrl=\"", 2240, "\"", 2283, 2);
            WriteAttributeValue("", 2251, "/Drzava/UrediForm?Id=", 2251, 21, true);
#line 49 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
WriteAttributeValue("", 2272, x.DrzavaId, 2272, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2284, 94, true);
            WriteLiteral(" class=\"btn btn-outline-secondary\"><i class=\"far fa-edit\"></i></a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2378, "\"", 2414, 2);
            WriteAttributeValue("", 2385, "/Drzava/Obrisi?Id=", 2385, 18, true);
#line 50 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
WriteAttributeValue("", 2403, x.DrzavaId, 2403, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2415, 121, true);
            WriteLiteral(" class=\"btn btn-outline-warning\"><i class=\"far fa-trash-alt\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 53 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Drzava\Prikazi.cshtml"
            }

#line default
#line hidden
            BeginContext(2551, 50, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(2601, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f8dd369107b4734b6ba5d397472e39d", async() => {
                BeginContext(2697, 37, true);
                WriteLiteral("<i class=\"fas fa-backward\"></i> Nazad");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-DostavaID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DostavaID"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2738, 486, true);
            WriteLiteral(@"

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 style=""padding:5px;"">Uredi državu</h3>
                <span class=""close"">&times;</span>
            </div>
            <div class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <div class=""logo"" style=""padding:0 10px"">
                    ");
            EndContext();
            BeginContext(3224, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "348495f805f04315a0a7ef0b709b45f5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3310, 1316, true);
            WriteLiteral(@"
                    <span style=""font-size:1.3em;"">BrzaPošta</span>
                </div>
            </div>
        </div>

    </div>

</div>
   
<script>
        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the button that opens the modal
        //var btn = document.getElementById(""myBtn"");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        // When the user clicks the button, open the modal
        $(""a[modal-poziv='da']"").click(function () {
            modal.style.display = ""block"";

            var btn = $(this);
            var url = btn.attr(""modalUrl"");

            $.get({
                url: url,
                success: function (rez) {
                    $("".modal-body"").html(rez);
                }
            });
        });


        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
      ");
            WriteLiteral(@"      modal.style.display = ""none"";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrzavaPrikaziVM> Html { get; private set; }
    }
}
#pragma warning restore 1591