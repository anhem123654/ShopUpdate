#pragma checksum "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40cb3ac243fb717f7241cbfd95d1b87088680cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40cb3ac243fb717f7241cbfd95d1b87088680cc7", @"/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a025a49ffac159cab466f4b87ddf75695580a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<eShopSolution.ViewModels.Catalog.Categries.CategoryVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"sidebar\" class=\"span3\">\n    <div class=\"well well-small\">\n        <a id=\"myCart\"");
            BeginWriteAttribute("href", " href=\"", 278, "\"", 299, 3);
            WriteAttributeValue("", 285, "/", 285, 1, true);
#nullable restore
#line 8 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 286, culture, 286, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 294, "/cart", 294, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <img src=\"/themes/images/ico-cart.png\" alt=\"cart\">3 Items in your cart\n            <span class=\"badge badge-warning pull-right\">$155.00</span>\n        </a>\n    </div>\n    <ul id=\"sideManu\" class=\"nav nav-tabs nav-stacked\">\n");
#nullable restore
#line 14 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
          
            var parents = Model.Where(x => x.ParentId == null);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
         for (int index = 0; index < parents.Count(); index++)
        {
            var parent = parents.ElementAt(index);
            var children = Model.Where(x => x.ParentId == parent.Id);
            if (children.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"subMenu open\">\n                    <a> ");
#nullable restore
#line 24 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
                   Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    <ul>\n");
#nullable restore
#line 26 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
                         foreach (var item in children)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1147, 6);
            WriteAttributeValue("", 1108, "/", 1108, 1, true);
#nullable restore
#line 28 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 1109, culture, 1109, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1117, "/", 1117, 1, true);
#nullable restore
#line 28 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 1118, _loc["categoryUrl"], 1118, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1138, "/", 1138, 1, true);
#nullable restore
#line 28 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 1139, item.Id, 1139, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-chevron-right\"></i>");
#nullable restore
#line 28 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\n");
#nullable restore
#line 29 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </li>\n");
#nullable restore
#line 32 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1345, "\"", 1393, 6);
            WriteAttributeValue("", 1352, "/", 1352, 1, true);
#nullable restore
#line 35 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 1353, culture, 1353, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1361, "/", 1361, 1, true);
#nullable restore
#line 35 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 1362, _loc["categoryUrl"], 1362, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1382, "/", 1382, 1, true);
#nullable restore
#line 35 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
WriteAttributeValue("", 1383, parent.Id, 1383, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
                                                                   Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 36 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/SideBar/Default.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n    <br />\n");
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<eShopSolution.ViewModels.Catalog.Categries.CategoryVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
