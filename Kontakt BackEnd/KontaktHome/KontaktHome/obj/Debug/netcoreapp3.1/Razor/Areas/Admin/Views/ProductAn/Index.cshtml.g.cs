#pragma checksum "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b9e1c458006d83823233d4184a89a785d6eb089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductAn_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductAn/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\_ViewImports.cshtml"
using KontaktHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\_ViewImports.cshtml"
using KontaktHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\_ViewImports.cshtml"
using KontaktHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b9e1c458006d83823233d4184a89a785d6eb089", @"/Areas/Admin/Views/ProductAn/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a509a57ffab89e044b612a000fbc3092cc8ad5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductAn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item d-block p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n\r\n    <!-- Basic initialization -->\r\n\r\n    <div class=\"card\">\r\n        <div class=\"card-header header-elements-inline\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                              Write(ViewBag.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"btn-create ml-3\" style=\"color:white\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9e1c458006d83823233d4184a89a785d6eb0895967", async() => {
                WriteLiteral("Yarat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                                                     WriteLiteral(ViewBag.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <table class=""table datatable-row-basic"">
            <thead>
                <tr>
                    <th>Say</th>
                    <th>????kil</th>
                    <th>Model</th>
                    <th>Kod</th>
                    <th>Qiymeti</th>
                    <th>Brend</th>
                    <th>Status</th>
                    <th class=""text-center"">Settings</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                   Write(product.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1109, "\"", 1163, 2);
            WriteAttributeValue("", 1115, "/img/products/", 1115, 14, true);
#nullable restore
#line 35 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
WriteAttributeValue("", 1129, product.Images.ElementAt(0).Image, 1129, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:60px;width:60px; object-fit:cover\" /></td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                   Write(product.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>");
#nullable restore
#line 38 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 39 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                   Write(product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                   \r\n");
#nullable restore
#line 41 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                     if (product.IsDeleted)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-secondary\">Deactive</span></td>\r\n");
#nullable restore
#line 44 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-success\">Active</span></td>\r\n");
#nullable restore
#line 48 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <td class=""text-center"">
                        <div class=""list-icons"">
                            <div class=""dropdown"">
                                <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                    <i class=""icon-menu9""></i>
                                </a>

                                <div class=""dropdown-menu dropdown-menu-right text-center"">
");
#nullable restore
#line 58 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                     if (product.IsDeleted)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9e1c458006d83823233d4184a89a785d6eb08913181", async() => {
                WriteLiteral("Aktiv Et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                                                     WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 61 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9e1c458006d83823233d4184a89a785d6eb08915896", async() => {
                WriteLiteral("Deaktiv Et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                                                     WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 65 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9e1c458006d83823233d4184a89a785d6eb08918528", async() => {
                WriteLiteral("D??z??li?? Et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\hp\Desktop\EndProjectKontaktHome\Kontakt BackEnd\KontaktHome\KontaktHome\Areas\Admin\Views\ProductAn\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <!-- /basic initialization -->\r\n</div>\r\n\r\n");
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
