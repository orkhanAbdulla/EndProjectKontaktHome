#pragma checksum "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9fb6f2950cba4744c6d832716e34295e0904ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PrdoductSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PrdoductSlider/Default.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\_ViewImports.cshtml"
using KontaktHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\_ViewImports.cshtml"
using KontaktHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\_ViewImports.cshtml"
using KontaktHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9fb6f2950cba4744c6d832716e34295e0904ef4", @"/Views/Shared/Components/PrdoductSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b16daef187a07f9dff296d33a1bd8bde321a45d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PrdoductSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"shop-items\">\r\n    <!-- view componentte alanda burdaki ro View Bagla gelmelidi -->\r\n    <div class=\"shop-slider row\">\r\n        <div class=\"carouseldiv swiper-container\">\r\n            <div class=\"main-carousel swiper-wrapper\">\r\n");
#nullable restore
#line 11 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                 foreach (Product pro in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""item swiper-slide"" style=""width: 277px;"">
                        <div class=""cart-item xustekcart"">
                            <div class=""cart-body-top"">
                                <div class=""imgHolder"">

                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9fb6f2950cba4744c6d832716e34295e0904ef45399", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9fb6f2950cba4744c6d832716e34295e0904ef45694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 769, "~/img/products/", 769, 15, true);
#nullable restore
#line 19 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
AddHtmlAttributeValue("", 784, pro.Images[0].Image, 784, 20, false);

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
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                                                                       WriteLiteral(pro.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                    <div class=""lbl-cash-discount lbl-120-per lbl-percentage-grid-2021-360"">
                                        <img src=""https://kontakt.az/wp-content/uploads/2021/03/4_az.png"">
                                    </div>
");
#nullable restore
#line 25 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                     if (pro.Discount > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"lbl-percentage lbl-percentage-grid lbl-percentage-grid-2021-xususi\">\r\n                                            <p>Xüsusi təklif</p>\r\n                                        </div>\r\n");
#nullable restore
#line 30 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"name\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9fb6f2950cba4744c6d832716e34295e0904ef410822", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 34 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                   Write(pro.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                                                                       WriteLiteral(pro.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""lbl-2021 scale"" style=""background-color:#e3e3e3"">
                                        <p style=""color: #000 !important; font-weight: 700 !important"">0<small class=""azn_span"">M</small>.0%.18ay</p>
                                    </div>
                                </div>
                                <div class=""cart-footer"">
");
#nullable restore
#line 41 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                     if (pro.Discount > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"endirimvar\" style=\"color: #ff003c\" ;>\r\n                                            <span style=\"text-decoration: line-through; font-weight: normal; color: #282828;\">");
#nullable restore
#line 44 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                                                                                                         Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"azn_span\">₼</small></span><br><span class=\"nprice\" id=\"price-86071\">");
#nullable restore
#line 44 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                                                                                                                                                                                                      Write(pro.Price-((pro.Price * pro.Discount) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"azn_span\">₼</small></span>\r\n                                        </p>\r\n");
#nullable restore
#line 46 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            <span class=\"nprice\" id=\"price-692028\">");
#nullable restore
#line 50 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                                                              Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <small class=\" ‎azn_span\">₼</small>\r\n                                        </p>\r\n");
#nullable restore
#line 52 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <button class=\"btn-add-to-cart\" id=\"AddBasket\">Səbətə at</button>\r\n                                    <input type=\"hidden\" id=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 3282, "\"", 3297, 1);
#nullable restore
#line 55 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
WriteAttributeValue("", 3290, pro.Id, 3290, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </div>

                            <div class=""cart-add"">
                                <ul>

                                    <li>
                                        <p>Ekran</p> <span> 6.2"" </span>
                                    </li>
                                    <li>
                                        <p>Batareya</p> <span> 4000 (mAh) </span>
                                    </li>
                                    <li>
                                        <p>Zəmanət</p> <span> 1 il </span>
                                    </li>
                                    <li>
                                        <p>Zəmanət</p> <span> 1 il </span>
                                    </li>
                                    <li>
                                        <p>Zəmanət</p> <span> 1 il </span>
                                    </li>
                                </ul>
");
            WriteLiteral(@"                                <div class=""action"">
                                    <button type=""button"" class=""compare-button"" data-id=""692028""
                                            data-mid=""00627244"" data-price=""2099.99"">
                                        <div class=""icon"">
                                            <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-comparisonnew.png"">
                                            <img class=""active""
                                                 src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/comparisonnew.png"">

                                        </div>
                                        <span>Müqayisə et</span>
                                    </button>
                                    <button type=""button"" class=""select-item"" data-id=""692028""
                                            data-mid=""00627244"" data-price=""2099.99"">
                                ");
            WriteLiteral(@"        <div class=""icon"">
                                            <i class=""fa fa-heart-o"" aria-hidden=""true""></i>
                                        </div>
                                        <span>Seçilmiş et</span>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 100 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\Components\PrdoductSlider\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <!-- <div class=\"swiper-pagination\">\r\n\r\n            </div> -->\r\n        </div>\r\n        <div class=\"all-offers\">\r\n            <a class=\"#\" href=\"#\">Bütün təklifləri gör</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591