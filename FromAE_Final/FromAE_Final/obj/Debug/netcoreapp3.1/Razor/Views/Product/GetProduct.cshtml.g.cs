#pragma checksum "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67dd2f61978d1ad9b388b1a9195903efd1ce810b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProduct), @"mvc.1.0.view", @"/Views/Product/GetProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67dd2f61978d1ad9b388b1a9195903efd1ce810b", @"/Views/Product/GetProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152aa5ba87e9d7739812d6dd813d34b18340ffc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/star-white.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("star"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
  
    ViewData["Title"] = "GetProduct";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67dd2f61978d1ad9b388b1a9195903efd1ce810b5068", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<section class=\"sale_product mt-3\">\r\n\r\n    <div class=\"container\">\r\n\r\n        <div class=\"d-flex flex-wrap\">\r\n\r\n            <div class=\"col-12 col-lg-4\">\r\n\r\n                <div class=\"img\">\r\n");
#nullable restore
#line 17 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                     foreach (var item in ViewBag.Img)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67dd2f61978d1ad9b388b1a9195903efd1ce810b6710", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 445, "~/images/", 445, 9, true);
#nullable restore
#line 19 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
AddHtmlAttributeValue("", 454, item, 454, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-12 col-lg-8\">\r\n\r\n                <div class=\"title\">\r\n                    <h3>\r\n");
#nullable restore
#line 50 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                         foreach (var item in ViewBag.Name)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                           Write(item);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                                     
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                          \r\n                        </h3>\r\n    \r\n                    </div>\r\n    \r\n                    <div class=\"d-flex justify-content-between\">\r\n                        <div class=\"price col-6\">\r\n");
#nullable restore
#line 61 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                        foreach (var item in ViewBag.Price)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"font-weight-bold\">$ ");
#nullable restore
#line 63 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                                                     Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 64 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        </div>\r\n                    <div class=\"star col-6\">\r\n                        <ul class=\"d-flex \">\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67dd2f61978d1ad9b388b1a9195903efd1ce810b10745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67dd2f61978d1ad9b388b1a9195903efd1ce810b11897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67dd2f61978d1ad9b388b1a9195903efd1ce810b13049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67dd2f61978d1ad9b388b1a9195903efd1ce810b14201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67dd2f61978d1ad9b388b1a9195903efd1ce810b15353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>

                        </ul>
                    </div>
                </div>

                <div class=""info p-4 col-12"">
                    <div class=""d-flex bd-highlightn"">
                        <p class="" flex-grow-1 bd-highlight"">Zemanet</p>
                        <input class=""mr-2 bd-highlight"" type=""checkbox"">
                        <p class="" bd-highlight"">1 İl +$ 5 - <a");
            BeginWriteAttribute("href", " href=\"", 3296, "\"", 3303, 0);
            EndWriteAttribute();
            WriteLiteral(@">Zəmanət şərtləri</a> ilə tanış oldum</p>
                    </div>
                    <div class=""d-flex justify-content-between"">
                        <ul class=""col-6"">
                            <li>Vəziyyəti:</li>
                            <li>Göndəriş:</li>
                            <li>Çatdirilma:</li>


                        </ul>
                        <ul class=""col-6"">
                            <li>Yeni</li>
                            <li>5-7 gün</li>
                            <li>$ 22 в Azərbaycan</li>

                        </ul>

                    </div>

                    <div class=""d-flex flex-wrap"">
                        <button class=""btn btn-danger col-12 col-lg-6"">
                            ALMAQ
                        </button>
                        <img class=""col-12 col-lg-6 pt-2"" src=""images/az_product_payment_methods.png""");
            BeginWriteAttribute("alt", " alt=\"", 4217, "\"", 4223, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>


                </div>


            </div>


        </div>




    </div>




</section>


<section class=""mt-5"">
    <div class=""d-flex justify-content-center"">
        <h4>SPESIFIKASIYA</h4>
    </div>


    <div class=""container"">
        <div class=""tab-content  p-3 table-responsive"">
");
#nullable restore
#line 137 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
             foreach (var item in ViewBag.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"text-danger text-center\">");
#nullable restore
#line 139 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" spesifikasiyası</h5>\r\n");
#nullable restore
#line 140 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <table class=\"table table-striped col-6\" style=\"width:48%\">\r\n                        <tbody>\r\n");
#nullable restore
#line 147 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                             foreach (var item in ViewBag.Prop)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"even\">\r\n                                    <td>");
#nullable restore
#line 150 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 152 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <table class=\"table table-striped col-6\" style=\"width:48%\">\r\n                        <tbody>\r\n");
#nullable restore
#line 157 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                             foreach (var item in ViewBag.PropValue)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"even\">\r\n                                    <td>");
#nullable restore
#line 160 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 162 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Product\GetProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n\r\n           \r\n");
            WriteLiteral(@"        </div>
    </div>




</section>




<script>
    $(document).ready(function () {
        $('.owl-carousel').owlCarousel({
            loop: true,
            responsiveClass: true,
            responsive: {

                1000: {
                    items: 4,
                    nav: true,
                    loop: false
                }
            }
        })
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
