#pragma checksum "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d5217849527554801bb21a897545c860af5d19"
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
#nullable restore
#line 4 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\_ViewImports.cshtml"
using KontaktHome.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d5217849527554801bb21a897545c860af5d19", @"/Views/Products/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9238582f1297a93261abc65bee48457e6e620f92", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success cash"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            <div class=""row cart_row"" id=""cart_row"">
                <div class=""col-lg-8"">
                    <div class=""item-box-parent"" id=""item-box-parent"">
                        <div class=""item-box"">
                            <button id=""deleteAll"" class=""delete"">
                                <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/eraser.png""");
            BeginWriteAttribute("alt", " alt=\"", 627, "\"", 633, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"cart_remove_selecteds\">Hamısını sil</p>\r\n                            </button>\r\n                        </div>\r\n");
#nullable restore
#line 20 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                         foreach (BasketProductVM pro in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""cart_object"">
                                <div id=""selected-cart-item"">
                                    <div class=""chosen-cart"">
                                        <div class=""photo-box"">
                                            <div class=""imgHolder"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1d5217849527554801bb21a897545c860af5d196240", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1256, "~/img/products/", 1256, 15, true);
#nullable restore
#line 27 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
AddHtmlAttributeValue("", 1271, pro.ImageUrl, 1271, 13, false);

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
#line 36 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                           Write(pro.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                            </a>
                                                        </p>
                                                        <div class=""labels"">
                                                            <div class=""lbl-percentage"">
                                                                <p>18 ay <span>Faizsiz</span></p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""col-6"">
                                                    <div class=""second-half"">
                                                        <div class=""quantity"">
                                                            <p>Miqdar</p>
                                                            <button id=""decr");
            WriteLiteral("ease\"");
            BeginWriteAttribute("value", " value=\"", 2896, "\"", 2911, 1);
#nullable restore
#line 50 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
WriteAttributeValue("", 2904, pro.Id, 2904, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" background-color: transparent; border: none; width: 10px;\">-</button>\r\n                                                            <input type=\"number\" id=\"cart_amount\"");
            BeginWriteAttribute("value", " value=\"", 3089, "\"", 3107, 1);
#nullable restore
#line 51 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
WriteAttributeValue("", 3097, pro.Count, 3097, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" class=\"amount cart_amount cart_amount_782962\">\r\n                                                            <button id=\"increase\"");
            BeginWriteAttribute("value", " value=\"", 3246, "\"", 3261, 1);
#nullable restore
#line 52 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
WriteAttributeValue("", 3254, pro.Id, 3254, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""background-color: transparent; color: #ff003c; border: none; width: 10px; "">+</button>
                                                        </div>
                                                        <div class=""price"">
                                                            <p><span class=""nprice"" id=""pricePro"">");
#nullable restore
#line 55 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                                                             Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> <small class=""azn_span"">‎₼</small></p>
                                                        </div>
                                                        <button class=""remove cart_remove"" id=""cart_remove"">
                                                            <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/bin.png""");
            BeginWriteAttribute("alt", " alt=\"", 3971, "\"", 3977, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        </button>\r\n                                                        <input type=\"hidden\" id=\"cart_removeId\"");
            BeginWriteAttribute("value", " value=\"", 4143, "\"", 4158, 1);
#nullable restore
#line 60 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
WriteAttributeValue("", 4151, pro.Id, 4151, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""total-price"">
                                        <p>
                                            Cəmi: <span id=""total-price"">");
#nullable restore
#line 68 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                                    Write(pro.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"azn_span\">‎ ‎₼</span>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 73 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""wrapper"">
                        <h5>
                            Səbətdəki  ‎Məhsullar <span>
                            </span>
                        </h5>
                        <div class=""about"">
                            <div class=""price"">
                                <p>Məhsullar</p>
                                <p><span class=""pricespan"">");
#nullable restore
#line 85 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                      Write(ViewBag.ItemsTitalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span> ‎₼</span></p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"total\">\r\n                            <span class=\"pricetotal\">");
#nullable restore
#line 89 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Basket.cshtml"
                                                Write(ViewBag.ItemsTitalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span> ‎₼</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"wrapper\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d5217849527554801bb21a897545c860af5d1915695", async() => {
                WriteLiteral("Sifarişi rəsmiləşdir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
            $(document).ready(function () {
                $(document).on(""click"", ""#cart_remove"", function () {
                    var cart_removeId = $(this).next().val();
                    $.ajax({
                        url: ""/Products/RemoveBasket?id="" + cart_removeId,
                        type: ""Get"",
                        success: function (res) {
                            $(""#cart_row"").empty();
                            $(""#cart_row"").append(res);
                        }
                    });
                });
            })
        $(document).ready(function () {
            $(document).on(""click"", ""#deleteAll"", function () {
                $.ajax({
                    url: ""/Products/AllRemoveBasket"",
                    type: ""Get"",
                    success: function (res) {
                        $(""#cart_row"").empty();
                        $(""#cart_row"").append(res);
                    }
                });
            });
    ");
                WriteLiteral(@"    })
      
        $(document).on(""click"", ""#decrease"", function () {
            let input = $(this).next().val(function (i,oldval) {
                return --oldval;
            })
        })
        $(document).on(""click"", ""#increase"", function () {
            let input = $(this).prev().val(function (i, oldval) {
                return ++oldval;
            })
        })
        $(document).ready(function () {
            $(document).ready(function () {
                $(document).on(""click"", ""#increase"", function () {
                    var productId = $(this).val();
                    $.ajax({
                        url: ""/Products/IncreaseBasket?id="" + productId,
                        type: ""Get"",
                        success: function (res) {
                            $(""#cart_row"").empty();
                            $(""#cart_row"").append(res);
                        }
                    });
                });
            })
        })
        $(document).r");
                WriteLiteral(@"eady(function () {
            $(document).on(""click"", ""#decrease"", function () {
                var cart_removeId = $(this).val();
                $.ajax({
                    url: ""/Products/DecreaseBasket?id="" + cart_removeId,
                    type: ""Get"",
                    success: function (res) {
                        $(""#cart_row"").empty();
                        $(""#cart_row"").append(res);
                    }
                });
            });
        })
       
    </script>
");
            }
            );
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
