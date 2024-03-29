#pragma checksum "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab63594d604dabb5760671287c845ec77fe1af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab63594d604dabb5760671287c845ec77fe1af5", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a025a49ffac159cab466f4b87ddf75695580a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
  
    //pageIndex=?&keyword=?
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 29 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\n");
#nullable restore
#line 32 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 938, "\"", 977, 1);
#nullable restore
#line 35 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue("", 945, urlTemplate.Replace("{0}", "1"), 945, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\n            </li>\n            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1076, "\"", 1142, 1);
#nullable restore
#line 38 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue("", 1083, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1083, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\n            </li>\n");
#nullable restore
#line 40 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 46 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\n                </li>\n");
#nullable restore
#line 48 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1568, "\"", 1595, 2);
            WriteAttributeValue("", 1576, "Trang", 1576, 5, true);
#nullable restore
#line 51 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue(" ", 1581, i.ToString(), 1582, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1596, "\"", 1644, 1);
#nullable restore
#line 51 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue("", 1603, urlTemplate.Replace("{0}", i.ToString()), 1603, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 52 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1808, "\"", 1843, 1);
#nullable restore
#line 57 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue("", 1816, Model.PageCount.ToString(), 1816, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1844, "\"", 1910, 1);
#nullable restore
#line 57 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue("", 1851, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1851, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\n            </li>\n            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2071, 1);
#nullable restore
#line 60 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
WriteAttributeValue("", 2016, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2016, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\n            </li>\n");
#nullable restore
#line 62 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 64 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Shared/Components/Pager/Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
