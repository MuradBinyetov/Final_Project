#pragma checksum "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a11878a675732957aafdb667c916111fb71f8d63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a11878a675732957aafdb667c916111fb71f8d63", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152aa5ba87e9d7739812d6dd813d34b18340ffc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <a href=\"#\">\r\n            ");
#nullable restore
#line 10 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <label title=\"Toggle Drop-down\" class=\"drop-icon\" for=\"sm1\">▾</label>\r\n        </a>\r\n        <input type=\"checkbox\" id=\"sm1\">\r\n        <ul class=\"sub-menu\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
             foreach (var item1 in item.SubMenus)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 420, "\"", 486, 1);
#nullable restore
#line 18 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 427, Url.Action("GetCategories","Categoies",new { id=item1.Id}), 427, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
                                                                                     Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 19 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </ul>\r\n    </li>\r\n");
#nullable restore
#line 23 "C:\Users\User\source\repos\FromAE_Final\FromAE_Final\Views\Shared\Components\Menu\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591