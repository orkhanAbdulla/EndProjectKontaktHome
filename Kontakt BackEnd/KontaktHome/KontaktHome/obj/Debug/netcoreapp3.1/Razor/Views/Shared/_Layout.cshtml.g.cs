#pragma checksum "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "862ec516f8db90b160ebfaf0aee769e5258dad9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862ec516f8db90b160ebfaf0aee769e5258dad9c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6245da36d6e9a6f249a2f12bffd637e7d1a12e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\_Layout.cshtml"
  
    var controller = ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "862ec516f8db90b160ebfaf0aee769e5258dad9c5194", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale-2=1.0"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css""
          integrity=""sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://unpkg.com/swiper/swiper-bundle.min.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "862ec516f8db90b160ebfaf0aee769e5258dad9c5954", async() => {
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
                WriteLiteral("\r\n    <title>Kontakt Home – Sevindirir | Online Mağaza</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "862ec516f8db90b160ebfaf0aee769e5258dad9c7905", async() => {
                WriteLiteral("\r\n    <div class=\"menu-mask\"></div>\r\n    ");
#nullable restore
#line 21 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <section id=\"toolbar\">\r\n        <ul>\r\n            <li>\r\n                <a href=\"#\">\r\n                    <img class=\"lazy loaded\"\r\n                         data-src=\"https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-cart.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1087, "\"", 1093, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-cart.png""
                         data-was-processed=""true"">
                    <span class=""active cart_count"">0</span>
                    <p>Səbət</p>
                </a>
            </li>
            <li>
                <a href=""#"">
                    <img class=""lazy loaded"" data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-favorite.png""");
                BeginWriteAttribute("alt", " alt=\"", 1577, "\"", 1583, 0);
                EndWriteAttribute();
                WriteLiteral(@" src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-favorite.png"" data-was-processed=""true"">
                    <span class=""watchlist_count"">0</span>
                    <p>Seçilmişlər</p>
                </a>
            </li>
            <li>
                <a href=""#"">
                    <img style=""width:25px"" class=""lazy loaded"" data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-comparisonnew.png""");
                BeginWriteAttribute("alt", " alt=\"", 2047, "\"", 2053, 0);
                EndWriteAttribute();
                WriteLiteral(@" src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/tb-comparisonnew.png"" data-was-processed=""true"">
                    <span class=""active compare_count"">0</span>
                    <p>Müqayisələrim</p>
                </a>
            </li>
        </ul>
    </section>

    <main>
        ");
#nullable restore
#line 52 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <footer>
        <div id=""trrs"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-8 p-0"">
                        <div class=""links"">
                            <ul>
                                <li>İnformasiya</li>
                                <li>
                                    <a href=""https://kontakt.az/konfidensialliq-siyaseti/"">Konfidensiallıq siyasəti</a>
                                </li>
                                <li>
                                    <a href=""https://kontakt.az/hisse-hisse-odenis-shertleri/"">
                                        Hissə-hissə ödəniş
                                        şərtləri
                                    </a>
                                </li>
                            </ul>

                            <ul>
                                <li>Müştərilər</li>
                                <li><a href=""https://kontakt.az/ist");
                WriteLiteral(@"ifade-shertleri/"">Saytın istifadə şərtləri</a></li>
                                <li>
                                    <a href=""https://kontakt.az/geri-qaytarma-siyas%c9%99ti/"">Geri qaytarma siyasəti</a>
                                </li>
                                <li><a href=""https://kontakt.az/korporativ-satislar/"">Korporativ satışlar</a></li>
                                <li>
                                    <a href=""https://kontakt.az/sikay%c9%99tl%c9%99rin-idar%c9%99olunma-siyas%c9%99ti/"">
                                        Şikayətlərin
                                        idarəolunma siyasəti
                                    </a>
                                </li>
                            </ul>

                            <ul>
                                <li>Şirkət</li>
                                <li><a href=""https://kontakt.az/shirket-haqqinda-2/"">Şirkət haqqında</a></li>
                                <li><a href=""https://kontakt.az/kary");
                WriteLiteral(@"era/"">Karyera</a></li>
                            </ul>

                        </div>
                        <div class=""payment mob"">
                            <ul style=""margin-left:-4px"">
                                <li><img class=""lazy loaded"" data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/visa.png"" src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/visa.png"" data-was-processed=""true""></li>
                                <li><img class=""lazy loaded"" data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/master.png"" src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/master.png"" data-was-processed=""true""></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-4 p-0"">
                        <div class=""desktop-title head6title"">Əlaqə</div>
                        <div class=""head6title mob-title"">Məlumat");
                WriteLiteral(@" mərkəzi</div>
                        <div class=""contact"">
                            <div class=""phone"">
                                <div class=""icon"">
                                    <img class=""lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/mob.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/mob.png""
                                         data-was-processed=""true"">
                                    <img class=""active lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/mob-red.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/mob-red.png""
                                         data-was-processed=""true"">
                                </div>
                                <a");
                BeginWriteAttribute("href", " href=\"", 6465, "\"", 6472, 0);
                EndWriteAttribute();
                WriteLiteral(">*6060</a>\r\n                            </div>\r\n                            <div class=\"email-address\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 6612, "\"", 6619, 0);
                EndWriteAttribute();
                WriteLiteral(@">info@kontakt.az</a>
                            </div>
                            <div class=""location"">
                                <div class=""icon"">
                                    <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/location.png"">
                                    <img class=""active lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/location-red.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/location-red.png""
                                         data-was-processed=""true"">
                                </div>
                                <a href=""https://kontakt.az/magazalar"">Mağazalarımız xəritədə</a>
                            </div>
                        </div>
                        <div class=""contact"">
                            <div class=""phone"">
                                ");
                WriteLiteral(@"<div class=""icon iconnomre"">
                                    <img class=""lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/number.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/number.png""
                                         data-was-processed=""true"">
                                    <img class=""active lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/number.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/number.png""
                                         data-was-processed=""true"">
                                </div>
                                <a");
                BeginWriteAttribute("href", " href=\"", 8519, "\"", 8526, 0);
                EndWriteAttribute();
                WriteLiteral(@">012 310 24 24</a>
                            </div>
                            <div class=""location ml-3"">
                                <a href=""#"">
                                    <svg style=""width: 20px;height: 20px;"" version=""1.1"" id=""Layer_1""
                                         xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink""
                                         x=""0px"" y=""0px"" viewBox=""0 0 335 327"" xml:space=""preserve"">
                                    <style type=""text/css"">
                                        .st0 {
                                            fill: #FFFFFF;
                                        }

                                        .st1 {
                                            fill-rule: evenodd;
                                            clip-rule: evenodd;
                                            fill: #FFFFFF;
                                        }
</style>
                                   ");
                WriteLiteral(@" <g>
                                    <g>
                                    <g>
                                    <g>
                                    <path class=""st0""
                                          d=""M174.77,308.5c-5.29,0-9.7-4.15-9.97-9.49c-0.28-5.51,3.97-10.2,9.47-10.48 c35.52-1.78,68.31-17.2,92.34-43.41c50.07-54.64,46.36-139.83-8.27-189.9C203.7,5.15,118.51,8.86,68.44,63.5 c-42.63,46.52-47.4,115.22-11.6,167.08c3.13,4.54,1.99,10.76-2.55,13.89c-4.54,3.13-10.76,1.99-13.89-2.55 c-19.54-28.3-29.1-62.89-26.93-97.4C15.66,109.5,29.96,75.92,53.71,50c57.52-62.76,155.37-67.02,218.12-9.5 c62.76,57.52,67.02,155.37,9.5,218.12c-27.6,30.11-65.27,47.82-106.06,49.86C175.11,308.5,174.94,308.5,174.77,308.5z"">
                                                        </path>
                                                    </g>
                                                </g>
                                    <g>
                                    <path class=""st1""
                    ");
                WriteLiteral(@"                      d=""M112.38,94.89c-6.52,7.54-8.81,17.09-7.92,27.58c-3.86,41.93,59.45,107.71,100.82,103.71 c13.1,1.15,24.8-3.06,33.03-14.83c3.73-7.66,2.88-12.18,1.71-14.49c-3.4-6.76-25.79-14.15-33.11-17.13 c-4.33-1.76-14.07,4.69-16.75,8.27c-2.68,3.57-7.33,1.08-7.33,1.08c-10.51-5.26-38.38-35.98-42.61-46.98c0,0-2.04-4.88,1.78-7.2 c3.82-2.32,11.18-11.41,9.84-15.89c-1.34-4.48-12.03-32.95-12.03-32.95s-3.65-6.15-16.42-1.39 C123.38,84.67,117.73,87.86,112.38,94.89z"">
                                                    </path>
                                                </g>
                                            </g>
                                    <g>
                                    <path class=""st0""
                                          d=""M112.13,327c-3.34,0-6.6-1.67-8.49-4.71l-27.27-43.8c-1.66-2.67-1.97-5.96-0.83-8.89 c1.14-2.93,3.58-5.15,6.61-6l51.03-14.36c5.31-1.49,10.83,1.6,12.32,6.91c1.49,5.31-1.6,10.82-6.91,12.32l-38.23,10.76 l20.24,32.51c2.91,4.68,1.48,10.84-3.2,13.76C115.76,3");
                WriteLiteral(@"26.51,113.94,327,112.13,327z"">
                                                </path>
                                            </g>
                                        </g>
                                    </svg>
                                    <span>Mənə zəng et</span>
                                </a>
                            </div>
                        </div>
                        <div class=""social-link"">
                            <div class=""head"">Bizimlə qalın</div>
                            <ul style=""margin-left:-10px"">
                                <li>
                                    <a target=""_blank"" href=""https://bit.ly/KontaktHome_Facebook"" class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/fb.png"">
                                    </a>
                                </li>
                                <li>
                                    <a target=""_b");
                WriteLiteral(@"lank"" href=""https://youtube.com/c/KontaktHome-TV"" class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/youtube.png"">
                                    </a>
                                </li>
                                <li class=""ig"">
                                    <div class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/insta.png"">
                                    </div>
                                    <div class=""ig-links"">
                                        <a target=""_blank"" href=""https://bit.ly/KontaktHome_Instagram"">Kontakt Home</a>
                                        <a target=""_blank"" href=""https://bit.ly/KontaktHome_Mebel_Instagram"">
                                            Kontakt
                                            Home Mebel
                                        </a>
                ");
                WriteLiteral(@"                    </div>
                                </li>
                                <li>
                                    <a target=""_blank"" href=""https://www.linkedin.com/company/kontakthome"" class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/linkedin.png"">
                                    </a>
                                </li>
                                <li>
                                    <a target=""_blank"" href=""https://wa.me/994508286060"" class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/wp.png"">
                                    </a>
                                </li>
                                <li>
                                    <a target=""_blank"" href=""https://t.me/kontakt_az"" class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kon");
                WriteLiteral(@"takt7/ktn-assets/assets/2021/telegram.png"">
                                    </a>
                                </li>
                                <li>
                                    <a target=""_blank"" href=""https://vm.tiktok.com/ZSJRp5gYp/"" class=""icon"">
                                        <img src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/tiktok.png"">
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div class=""payment"">
                            <ul>
                                <li>
                                    <img class=""lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/visa.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/visa.png""
                               ");
                WriteLiteral(@"          data-was-processed=""true"">
                                </li>
                                <li>
                                    <img class=""lazy loaded""
                                         data-src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/master.png""
                                         src=""https://kontakt.az/wp-content/themes/kontakt7/ktn-assets/assets/2021/master.png""
                                         data-was-processed=""true"">
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""copy-right"">
                            <p>© 2021 Kontakt Home </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>

    <script src=""https://code.jquer");
                WriteLiteral(@"y.com/jquery-3.5.1.slim.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""https://kit.fontawesome.com/b6281e7052.js"" crossorigin=""anonymous""></script>
    <script src=""https://unpkg.com/swiper/swiper-bundle.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "862ec516f8db90b160ebfaf0aee769e5258dad9c26532", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
