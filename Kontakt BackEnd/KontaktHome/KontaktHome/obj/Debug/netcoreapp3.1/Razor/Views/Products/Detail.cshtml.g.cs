#pragma checksum "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31081a3f0cb9d4a358c85b1527be4db9ef5e70fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Detail), @"mvc.1.0.view", @"/Views/Products/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31081a3f0cb9d4a358c85b1527be4db9ef5e70fa", @"/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b16daef187a07f9dff296d33a1bd8bde321a45d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid detail-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main-detail-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-features"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    int count = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""product-details"">
        <div class=""container"">
            <div class=""product-headline"">
                <div class=""product-status"">
                    <p class=""success"">
                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/check.png""");
            BeginWriteAttribute("alt", " alt=\"", 398, "\"", 404, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        Məhsul mövcuddur\r\n                    </p>\r\n                    <p>Məhsul kodu: <span>");
#nullable restore
#line 17 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                     Write(ViewBag.cod);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                </div>
                <div class=""product-feedback"">
                    <button class=""feedback-action select-item"" data-id=""50244"" data-mid=""0026196"" data-price=""1099.99"">
                        <svg viewBox=""0 -28 512.001 512"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""m256 455.515625c-7.289062 0-14.316406-2.640625-19.792969-7.4375-20.683593-18.085937-40.625-35.082031-58.21875-50.074219l-.089843-.078125c-51.582032-43.957031-96.125-81.917969-127.117188-119.3125-34.644531-41.804687-50.78125-81.441406-50.78125-124.742187 0-42.070313 14.425781-80.882813 40.617188-109.292969 26.503906-28.746094 62.871093-44.578125 102.414062-44.578125 29.554688 0 56.621094 9.34375 80.445312 27.769531 12.023438 9.300781 22.921876 20.683594 32.523438 33.960938 9.605469-13.277344 20.5-24.660157 32.527344-33.960938 23.824218-18.425781 50.890625-27.769531 80.445312-27.769531 39.539063 0 75.910156 15.832031 102.414063 44.578125 26.191406 28.410156 40.613281 67.222656 40");
            WriteLiteral(@".613281 109.292969 0 43.300781-16.132812 82.9375-50.777344 124.738281-30.992187 37.398437-75.53125 75.355469-127.105468 119.308594-17.625 15.015625-37.597657 32.039062-58.328126 50.167969-5.472656 4.789062-12.503906 7.429687-19.789062 7.429687zm-112.96875-425.523437c-31.066406 0-59.605469 12.398437-80.367188 34.914062-21.070312 22.855469-32.675781 54.449219-32.675781 88.964844 0 36.417968 13.535157 68.988281 43.882813 105.605468 29.332031 35.394532 72.960937 72.574219 123.476562 115.625l.09375.078126c17.660156 15.050781 37.679688 32.113281 58.515625 50.332031 20.960938-18.253907 41.011719-35.34375 58.707031-50.417969 50.511719-43.050781 94.136719-80.222656 123.46875-115.617188 30.34375-36.617187 43.878907-69.1875 43.878907-105.605468 0-34.515625-11.605469-66.109375-32.675781-88.964844-20.757813-22.515625-49.300782-34.914062-80.363282-34.914062-22.757812 0-43.652344 7.234374-62.101562 21.5-16.441406 12.71875-27.894532 28.796874-34.609375 40.046874-3.453125 5.785157-9.53125 9.238282-16.261719 9.238282s-12.80859");
            WriteLiteral(@"4-3.453125-16.261719-9.238282c-6.710937-11.25-18.164062-27.328124-34.609375-40.046874-18.449218-14.265626-39.34375-21.5-62.097656-21.5zm0 0""></path>
                        </svg>
                    </button>
                    <button class=""feedback-action compare-button"" data-id=""50244"" data-mid=""0026196"" data-price=""1099.99"">
                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/comparisonnew2.png"" style=""width:21px"">
                    </button>
                </div>
            </div>
            <div id=""product-info"">
                <div class=""product-slider"">

                    <div class=""images"">
");
#nullable restore
#line 34 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                         for (int i = 0; i < Model.Images.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n                                <a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31081a3f0cb9d4a358c85b1527be4db9ef5e70fa9507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3486, "~/img/products/", 3486, 15, true);
#nullable restore
#line 38 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 3501, Model.Images[i].Image, 3501, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 41 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"base-image\">\r\n                        <div class=\"imgContainer\">\r\n                            <a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31081a3f0cb9d4a358c85b1527be4db9ef5e70fa11658", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3862, "~/img/products/", 3862, 15, true);
#nullable restore
#line 48 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 3877, Model.Images[0].Image, 3877, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31081a3f0cb9d4a358c85b1527be4db9ef5e70fa13496", async() => {
                WriteLiteral("\r\n                    <div class=\"wrapper\">\r\n                        <div class=\"feature-container\">\r\n                            <h1 class=\"title\">");
#nullable restore
#line 56 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
                            <img class=""undertitle_icon"" src=""https://kontakt.az/wp-content/uploads/2021/03/1.png"" style=""height: 34.8px;"">
                            <a class=""undertitle_icon_a"" href=""https://kontakt.az/en-serfeli-qiymetle-120-zemanet/"" target=""_blank"">
                                <img class=""undertitle_icon undertitle_icon_2"" src=""https://kontakt.az/wp-content/uploads/2021/03/2.png"" data-placement=""top"" data-toggle=""popover"" data-html=""true"" data-content=""Məhsul rəsmi şəbəkələrdə daha ucuz olduğu halda fərq 120% geri ödənilir. <i class='fa fa-close fa-closep fa-closep120'></i>"" data-original-title=""""");
                BeginWriteAttribute("title", " title=\"", 4908, "\"", 4916, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </a>
                            <img class=""undertitle_icon"" src=""https://kontakt.az/wp-content/uploads/2021/03/visaaz.png"" style=""height: 34.8px;"">
                            <div class=""feature"">
                                <div class=""labels"">
                                    <a href=""#"" data-toggle=""tooltip"" data-placement=""bottom"" class=""lbl-box-new"" data-html=""true""");
                BeginWriteAttribute("title", " title=\"", 5335, "\"", 5343, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"<p>Nağd alışda endirim.</p>\">\r\n                                        <img src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/badges/gray-nagd.png\"");
                BeginWriteAttribute("alt", " alt=\"", 5532, "\"", 5538, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </a>\r\n                                    <a href=\"#\" data-toggle=\"tooltip\" data-placement=\"bottom\" class=\"lbl-box-new temporary_hidden\" data-html=\"true\"");
                BeginWriteAttribute("title", " title=\"", 5731, "\"", 5739, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"<p>Sürətli çatdırılma imkanı.</p>\">\r\n                                        <img src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/badges/gray-express.png\"");
                BeginWriteAttribute("alt", " alt=\"", 5937, "\"", 5943, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </a>\r\n                                    <a href=\"#\" data-toggle=\"tooltip\" data-placement=\"bottom\" class=\"lbl-box-new\" data-html=\"true\"");
                BeginWriteAttribute("title", " title=\"", 6119, "\"", 6127, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"<p>Kartla ödəmə imkanı.</p>\">\r\n                                        <img src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/badges/gray-kart.png\"");
                BeginWriteAttribute("alt", " alt=\"", 6316, "\"", 6322, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </a>\r\n                                    <a href=\"#\" data-toggle=\"tooltip\" data-placement=\"bottom\" class=\"lbl-box-new\" data-html=\"true\"");
                BeginWriteAttribute("title", " title=\"", 6498, "\"", 6506, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"<p>Online ödəmə imkanı.</p>\">\r\n                                        <img src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/badges/gray-online.png\"");
                BeginWriteAttribute("alt", " alt=\"", 6697, "\"", 6703, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </a>\r\n                                    <a href=\"#\" data-toggle=\"tooltip\" data-placement=\"bottom\" class=\"lbl-box-new\" data-html=\"true\"");
                BeginWriteAttribute("title", " title=\"", 6879, "\"", 6887, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"<p>Qapıda ödəmə imkanı.</p>\">\r\n                                        <img src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/badges/gray-qapida.png\"");
                BeginWriteAttribute("alt", " alt=\"", 7078, "\"", 7084, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                            </div>
                            <div class=""cont-price"">
                                <div class=""calculator-responsive-select-mother"">
                                    <div class=""price"">
                                        <small class=""qiymeti  qiymeti_endirim"">
                                            qiyməti
                                        </small>
");
#nullable restore
#line 87 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                         if (Model.Discount > 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <p class=\"endirimvar\">\r\n                                                <span style=\"text-decoration: line-through; font-weight: normal; color:#282828; \">");
#nullable restore
#line 90 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                                                                                                             Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small class=\"azn_span\">₼</small></span><br><span class=\"nprice\" id=\"price-327650\">");
#nullable restore
#line 90 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                                                                                                                                                                                                             Write(Model.Price-((Model.Price * Model.Discount) / 100));

#line default
#line hidden
#nullable disable
                WriteLiteral("<small class=\"azn_span\">₼</small></span>\r\n                                            </p>\r\n");
#nullable restore
#line 92 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <p class=\"p-price\"><span class=\"nprice\" id=\"price-751190\">");
#nullable restore
#line 95 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                                                                                 Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> <small class=\"azn_span\">₼</small></p>\r\n");
#nullable restore
#line 96 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""mop"">
                        <button type=""button"" class=""btn-add-to-cart"" id=""AddBasket"">Səbətə at</button>
                        <input type=""hidden"" id=""ProductId""");
                BeginWriteAttribute("value", " value=\"", 8851, "\"", 8868, 1);
#nullable restore
#line 104 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
WriteAttributeValue("", 8859, Model.Id, 8859, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
    </section>
    <section id=""tabs"">
        <div class=""container"">
            <div class=""nav"">
                <a> Xüsusiyyətlər</a>
            </div>
            <div class=""tab-content"">
                <div class=""row"">
                    <div class=""col-lg-4 pr-0"">
                        <ul class=""features-review-tabs"">
");
#nullable restore
#line 120 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                              
                                foreach (ProductFeatures pf in Model.ProductFeatures)
                                {
                                    if (count % 2 == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            ");
#nullable restore
#line 126 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                       Write(pf.FeaturesDetail.Features.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 128 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"gray-line\">\r\n                                            ");
#nullable restore
#line 132 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                       Write(pf.FeaturesDetail.Features.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 134 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"

                                    }
                                    count++;
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"col-lg-8 pl-0\">\r\n                        <ul class=\"features-review-tabs submenuItems_params\">\r\n");
#nullable restore
#line 146 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                              
                                foreach (ProductFeatures pf in Model.ProductFeatures)
                                {
                                    if (count % 2 == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            ");
#nullable restore
#line 152 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                       Write(pf.FeaturesDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 154 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"gray-line\">\r\n                                            ");
#nullable restore
#line 158 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"
                                       Write(pf.FeaturesDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n");
#nullable restore
#line 160 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Products\Detail.cshtml"

                                    }
                                    count++;
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            $(document).ready(function () {
                $(document).on(""click"", ""#AddBasket"", function () {
                    var productId = $(this).next().val();
                    alertify.set('notifier', 'delay', 1);
                    alertify.set('notifier', 'position', 'bottom-center');
                    alertify.error('İcra edildi!');
                    $.ajax({
                        url: ""/Products/AddBasket?id="" + productId,
                        type: ""Get"",
                        success: function (res) {
                            $("".cart_count"").empty();
                            $("".cart_count"").append(res);
                        }
                    });
                });
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
