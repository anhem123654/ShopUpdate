#pragma checksum "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76675403119f71081f941c63d832715a46045706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76675403119f71081f941c63d832715a46045706", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a025a49ffac159cab466f4b87ddf75695580a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul class=\"breadcrumb\">\n    <li><a href=\"/\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a460457064762", async() => {
                WriteLiteral("Home");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a> <span class=\"divider\">/</span></li>\n    <li class=\"active\">");
#nullable restore
#line 12 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
                  Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>\n\n<div class=\"row\">\n    <div id=\"gallery\" class=\"span3\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 600, 1);
#nullable restore
#line 17 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
WriteAttributeValue("", 538, Configuration["BaseAddress"] + Model.Product.ThumbnailImage, 538, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 601, "\"", 628, 1);
#nullable restore
#line 17 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
WriteAttributeValue("", 609, Model.Product.Name, 609, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <img");
            BeginWriteAttribute("src", " src=\"", 647, "\"", 715, 1);
#nullable restore
#line 18 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
WriteAttributeValue("", 653, Configuration["BaseAddress"] + Model.Product.ThumbnailImage, 653, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"");
            BeginWriteAttribute("alt", " alt=\"", 735, "\"", 760, 1);
#nullable restore
#line 18 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
WriteAttributeValue("", 741, Model.Product.Name, 741, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </a>
        <div id=""differentview"" class=""moreOptopm carousel slide"">
            <div class=""carousel-inner"">
                <div class=""item active"">
                    <a href=""themes/images/products/large/f1.jpg""> <img style=""width:29%"" src=""themes/images/products/large/f1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1059, "\"", 1065, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\n                    <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1205, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\n                    <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1351, "\"", 1357, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\n                </div>\n                <div class=\"item\">\n                    <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1555, "\"", 1561, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\n                    <a href=\"themes/images/products/large/f1.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1701, "\"", 1707, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\n                    <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1847, "\"", 1853, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                </div>
            </div>
            <!--
            <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">‹</a>
            <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">›</a>
            -->
        </div>

        <div class=""btn-toolbar"">
            <div class=""btn-group"">
                <span class=""btn""><i class=""icon-envelope""></i></span>
                <span class=""btn""><i class=""icon-print""></i></span>
                <span class=""btn""><i class=""icon-zoom-in""></i></span>
                <span class=""btn""><i class=""icon-star""></i></span>
                <span class=""btn""><i class="" icon-thumbs-up""></i></span>
                <span class=""btn""><i class=""icon-thumbs-down""></i></span>
            </div>
        </div>
    </div>
    <div class=""span6"">
        <h3>");
#nullable restore
#line 51 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <small>");
#nullable restore
#line 52 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
          Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n        <hr class=\"soft\" />\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570611009", async() => {
                WriteLiteral(@"
            <div class=""control-group"">
                <label class=""control-label""><span>$222.00</span></label>
                <div class=""controls"">
                    <input type=""number"" class=""span1"" placeholder=""Qty."" />
                    <button type=""submit"" class=""btn btn-large btn-primary pull-right""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570611598", async() => {
                    WriteLiteral("Add to");
                }
                );
                __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
                __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <i class=\" icon-shopping-cart\"></i></button>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        <hr class=\"soft\" />\n        <h4>100 items in stock</h4>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570613830", async() => {
                WriteLiteral("\n            <div class=\"control-group\">\n                <label class=\"control-label\"><span>Color</span></label>\n                <div class=\"controls\">\n                    <select class=\"span2\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570614315", async() => {
                    WriteLiteral("Black");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570615337", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570616357", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570617378", async() => {
                    WriteLiteral("Brown");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </select>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <hr class=\"soft clr\" />\n        <p>\n            ");
#nullable restore
#line 81 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
       Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <a class=\"btn btn-small pull-right\" href=\"#detail\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570619878", async() => {
                WriteLiteral("More Details");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n        <br class=\"clr\" />\n        <a href=\"#\" name=\"detail\"></a>\n        <hr class=\"soft\" />\n    </div>\n\n    <div class=\"span9\">\n        <ul id=\"productDetail\" class=\"nav nav-tabs\">\n            <li class=\"active\"><a href=\"#home\" data-toggle=\"tab\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570621123", async() => {
                WriteLiteral("Product Details");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\n            <li><a href=\"#profile\" data-toggle=\"tab\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570622158", async() => {
                WriteLiteral("Related Products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\n        </ul>\n        <div id=\"myTabContent\" class=\"tab-content\">\n            <div class=\"tab-pane fade active in\" id=\"home\">\n                <h4>Product Information</h4>\n                ");
#nullable restore
#line 97 "/Users/mannguyen/Projects/eShopSolution/eShopSolution.WebApp/Views/Product/Detail.cshtml"
           Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""tab-pane fade"" id=""profile"">
                <div id=""myTab"" class=""pull-right"">
                    <a href=""#listView"" data-toggle=""tab""><span class=""btn btn-large""><i class=""icon-list""></i></span></a>
                    <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
                </div>
                <br class=""clr"" />
                <hr class=""soft"" />
                <div class=""tab-content"">
                    <div class=""tab-pane"" id=""listView"">
                        <div class=""row"">
                            <div class=""span2"">
                                <img src=""themes/images/products/4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5445, "\"", 5451, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            </div>
                            <div class=""span4"">
                                <h3>New | Available</h3>
                                <hr class=""soft"" />
                                <h5>Product Name </h5>
                                <p>
                                    Nowadays the lingerie industry is one of the most successful business spheres.We always stay in touch with the latest fashion tendencies -
                                    that is why our goods are so popular..
                                </p>
                                <a class=""btn btn-small pull-right"" href=""product_details.html"">View Details</a>
                                <br class=""clr"" />
                            </div>
                            <div class=""span3 alignR"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76675403119f71081f941c63d832715a4604570625372", async() => {
                WriteLiteral(@"
                                    <h3> $222.00</h3>
                                    <label class=""checkbox"">
                                        <input type=""checkbox"">  Adds product to compair
                                    </label><br />
                                    <div class=""btn-group"">
                                        <a href=""product_details.html"" class=""btn btn-large btn-primary""> Add to <i class="" icon-shopping-cart""></i></a>
                                        <a href=""product_details.html"" class=""btn btn-large""><i class=""icon-zoom-in""></i></a>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <hr class=""soft"" />
                    </div>
                    <div class=""tab-pane active"" id=""blockView"">
                        <ul class=""thumbnails"">
                            <li class=""span3"">
                                <div class=""thumbnail"">
                                    <a href=""product_details.html""><img src=""themes/images/products/10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7487, "\"", 7493, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                    <div class=""caption"">
                                        <h5>Manicure &amp; Pedicure</h5>
                                        <p>
                                            Lorem Ipsum is simply dummy text.
                                        </p>
                                        <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">&euro;222.00</a></h4>
                                    </div>
                                </div>
                            </li>
                        </ul>
                        <hr class=""soft"" />
                    </div>
                </div>
                <br class=""clr"">
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
