#pragma checksum "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "729dd6b7544d42a34ff892713d1378b61d25f1eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Region_Prikazi), @"mvc.1.0.view", @"/Views/Region/Prikazi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Region/Prikazi.cshtml", typeof(AspNetCore.Views_Region_Prikazi))]
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
#line 3 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729dd6b7544d42a34ff892713d1378b61d25f1eb", @"/Views/Region/Prikazi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad51cb348a18d650f8d844709281a49f67ee662", @"/Views/_ViewImports.cshtml")]
    public class Views_Region_Prikazi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<RegionIndexVM>>
    {
        private global::AspNetCore.Views_Region_Prikazi.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/fast_delivery.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:45px; height:40px; padding:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-DostavaID", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
  
    ViewData["Title"] = "Prikazi";
    int brojac = 1;

    string porukaSuccess = TempData["poruka-success"] as string;

#line default
#line hidden
            BeginContext(268, 30, true);
            WriteLiteral("\r\n\r\n<div class=\"sadrzajDiv\">\r\n");
            EndContext();
#line 15 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
     if (porukaSuccess != null)
    {

#line default
#line hidden
            BeginContext(338, 70, true);
            WriteLiteral("        <div class=\"alert alert-success\" id=\"porukaBox\">\r\n            ");
            EndContext();
            BeginContext(409, 13, false);
#line 18 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
       Write(porukaSuccess);

#line default
#line hidden
            EndContext();
            BeginContext(422, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
    }

#line default
#line hidden
            BeginContext(447, 92, true);
            WriteLiteral("\r\n    <nav aria-label=\"Suppliers navigation example\" style=\"display:inline-block\">\r\n        ");
            EndContext();
            BeginContext(540, 74, false);
#line 23 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model }));

#line default
#line hidden
            EndContext();
            BeginContext(614, 494, true);
            WriteLiteral(@"
    </nav>

    <a id=""myBtn"" modal-poziv='da' modalUrl=""/Region/UrediForm"" class=""btn btn-outline-primary btn-lg"" style=""float:right; margin-bottom:5px; display:inline-block""><i class=""fas fa-plus""></i> Dodaj</a>
    <table class=""table table-bordered table-hover"" style=""margin:5px 0;"">
        <thead class=""table-light"">
            <tr>
                <th scope=""col"" colspan=""3"">Regioni</th>
            </tr>
        </thead>
        <tbody class=""table-light table-hover"">
");
            EndContext();
#line 34 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
             foreach (var x in Model)
            {


#line default
#line hidden
            BeginContext(1164, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1212, 8, false);
#line 38 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
                    Write(brojac++);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1253, 7, false);
#line 39 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1260, 87, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a id=\"myBtn\" modal-poziv=\'da\'");
            EndContext();
            BeginWriteAttribute("modalUrl", " modalUrl=\"", 1347, "\"", 1384, 2);
            WriteAttributeValue("", 1358, "/Region/UrediForm?Id=", 1358, 21, true);
#line 41 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
WriteAttributeValue("", 1379, x.Id, 1379, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1385, 94, true);
            WriteLiteral(" class=\"btn btn-outline-secondary\"><i class=\"far fa-edit\"></i></a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1479, "\"", 1509, 2);
            WriteAttributeValue("", 1486, "/Region/Obrisi?Id=", 1486, 18, true);
#line 42 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
WriteAttributeValue("", 1504, x.Id, 1504, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1510, 121, true);
            WriteLiteral(" class=\"btn btn-outline-warning\"><i class=\"far fa-trash-alt\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
            }

#line default
#line hidden
            BeginContext(1646, 97, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <nav aria-label=\"Suppliers navigation example\">\r\n        ");
            EndContext();
            BeginContext(1743, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d1c9ac8fed048248dc5d94c6d499e0e", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Region_Prikazi.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
#line 51 "C:\Users\kemal\source\repos\webapp\BrzaPosta\BrzaPosta\Views\Region\Prikazi.cshtml"
__PagerViewComponentTagHelper.pagingList = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("paging-list", __PagerViewComponentTagHelper.pagingList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1776, 498, true);
            WriteLiteral(@"
    </nav>

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 style=""padding:5px;"">Uredi region</h3>
                <span class=""close"">&times;</span>
            </div>
            <div class=""modal-body"">
            </div>
            <div class=""modal-footer"">
                <div class=""logo"" style=""padding:0 10px"">
                    ");
            EndContext();
            BeginContext(2274, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b01c7d3eed14d07802b494c4d2ddd33", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2360, 165, true);
            WriteLiteral("\r\n                    <span style=\"font-size:1.3em;\">BrzaPošta</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(2525, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b65b6f1fc704245a7aff886eede0b95", async() => {
                BeginContext(2621, 37, true);
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
            BeginContext(2662, 1066, true);
            WriteLiteral(@"
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
        modal.style.display = ""none"";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = ""non");
            WriteLiteral("e\";\r\n        }\r\n    }\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<RegionIndexVM>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pager")]
        public class __Generated__PagerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PagerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public ReflectionIT.Mvc.Paging.IPagingList pagingList { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Pager", new { pagingList });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
