#pragma checksum "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4fde97599bb52e5d0b65f2fa54f70d4bf2459a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Basket), @"mvc.1.0.view", @"/Views/Products/Basket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fde97599bb52e5d0b65f2fa54f70d4bf2459a3", @"/Views/Products/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b16daef187a07f9dff296d33a1bd8bde321a45d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove cart_remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
    <section id=""cart"">
        <div class=""container"">
            <div class=""head-title"">
                <h1>Səbət</h1>
            </div>
            <div class=""row cart_row"">
                <div class=""col-lg-8"">
                    <div class=""item-box-parent"">
                        <div class=""item-box"">
                            <input type=""checkbox"" class=""form-check-input select-items"" id=""select-items"">
                            <label class=""form-check-label"" for=""select-items"">
                                Hamısını seç
                            </label>
                            <button class=""delete"">
                                <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/eraser.png""");
            BeginWriteAttribute("alt", " alt=\"", 851, "\"", 857, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"cart_remove_selecteds\">Seçilənləri sil</p>\r\n                            </button>\r\n                        </div>\r\n");
#nullable restore
#line 24 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                         foreach (BasketProductVM pro in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""cart_object"">
                                <div id=""selected-cart-item"">
                                    <div class=""chosen-cart"">
                                        <div class=""checkbox"">
                                            <input type=""checkbox"" class=""form-check-input cart_select_item"" id=""select-782962"" data-id=""782962"">
                                            <label class=""form-check-label"" for=""select-782962""></label>
                                        </div>
                                        <div class=""photo-box"">
                                            <div class=""imgHolder"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c4fde97599bb52e5d0b65f2fa54f70d4bf2459a36943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1848, "~/img/products/", 1848, 15, true);
#nullable restore
#line 35 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
AddHtmlAttributeValue("", 1863, pro.ImageUrl, 1863, 13, false);

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
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""details"">
                                            <div class=""row"">
                                                <div class=""col-6"">
                                                    <div class=""features"">
                                                        <p>
                                                            <a href=""#"">
                                                                ");
#nullable restore
#line 44 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                           Write(pro.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                            </a>
                                                        </p>
                                                        <div class=""labels"">
                                                            <div class=""lbl-cash-discount"">
                                                                <p>
                                                                    -<span class=""cash-discount-782962"">100 AZN nağd alışa</span>
                                                                </p>
                                                            </div>
                                                            <div class=""lbl-percentage"">
                                                                <p>18 ay <span>Faizsiz</span></p>
                                                            </div>
                                                        </div>
                                                    </div>
    ");
            WriteLiteral(@"                                            </div>
                                                <div class=""col-6"">
                                                    <div class=""second-half"">
                                                        <div class=""quantity"">
                                                            <p>Miqdar</p>
                                                            <input type=""number"" id=""amount_782962""");
            BeginWriteAttribute("value", " value=\"", 3937, "\"", 3955, 1);
#nullable restore
#line 63 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
WriteAttributeValue("", 3945, pro.Count, 3945, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" min=""0"" class=""amount cart_amount cart_amount_782962"" data-id=""782962"">
                                                        </div>
                                                        <div class=""price"">
                                                            <p><span class=""nprice"" id=""price-782962"">");
#nullable restore
#line 66 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                                                                 Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <small class=\"azn_span\">‎₼</small></p>\r\n                                                        </div>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4fde97599bb52e5d0b65f2fa54f70d4bf2459a312108", async() => {
                WriteLiteral("\r\n                                                            <img src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/bin.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4700, "\"", 4706, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                                                                                 WriteLiteral(pro.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""total-price"">
                                        <p>
                                            Cəmi: <span>");
#nullable restore
#line 78 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                   Write(pro.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"azn_span\">‎ ‎₼</span>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 83 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""wrapper"">
                        <h5>
                            Səbətdəki  ‎₼əhsullar <span>
                            </span>
                        </h5>
                        <div class=""about"">
                            <div class=""price"">
                                <p>Məhsullar</p>
                                <p><span class=""pricespan"">4099.93</span><span> ‎₼</span></p>
                            </div>
                            <div class=""price neqdalisaendirim_li"">
                                <p>Nağd alış endirimi</p>
                                <p>
                                    <span class=""pricediscount discount"">440</span> <span>‎₼</span>
                                </p>
                            </div>
                        </div>
                        <div class=""total"">
                            <span class=""");
            WriteLiteral(@"pricetotal"">3659.93</span><span> ‎₼</span>
                        </div>
                    </div>
                    <div class=""wrapper"">
                        <a type=""button"" href=""#"" class=""btn btn-success cash"">Sifarişi rəsmiləşdir</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
