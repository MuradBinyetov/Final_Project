#pragma checksum "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b499b38d9a0c9981b98dac5fc672c42422c09400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoies_GetCategories), @"mvc.1.0.view", @"/Views/Categoies/GetCategories.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\_ViewImports.cshtml"
using FromAE_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\_ViewImports.cshtml"
using FromAE_Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b499b38d9a0c9981b98dac5fc672c42422c09400", @"/Views/Categoies/GetCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152aa5ba87e9d7739812d6dd813d34b18340ffc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoies_GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
  
    ViewData["Title"] = "GetCategories";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div style=\"background-color: #eee;\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 return-home\"><a");
            BeginWriteAttribute("href", " href=\"", 212, "\"", 219, 0);
            EndWriteAttribute();
            WriteLiteral(@">Baş Səhifə</a></div>
            </div>
        </div>
    </div>
    <section class=""border pb-5"" style=""background-color: #eee;"">
        <div class=""container-fluid menu-h1"" style=""background-color: #fff;"">
            <div class=""row"">

                <div>
");
#nullable restore
#line 19 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
                     foreach (var item1 in ViewBag.Category)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 class=\"pb-1 pt-4\">");
#nullable restore
#line 21 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
                                         Write(item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 22 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"submenus\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 921, "\"", 977, 1);
#nullable restore
#line 32 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
WriteAttributeValue("", 928, Url.Action("Filter","Product",new { id=item.Id}), 928, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 978, "\"", 996, 1);
#nullable restore
#line 32 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
WriteAttributeValue("", 986, item.Name, 986, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b499b38d9a0c9981b98dac5fc672c42422c094006434", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1053, "~/images/", 1053, 9, true);
#nullable restore
#line 33 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
AddHtmlAttributeValue("", 1062, item.Image, 1062, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
AddHtmlAttributeValue("", 1080, item.Name, 1080, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <span>");
#nullable restore
#line 34 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Categoies\GetCategories.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
