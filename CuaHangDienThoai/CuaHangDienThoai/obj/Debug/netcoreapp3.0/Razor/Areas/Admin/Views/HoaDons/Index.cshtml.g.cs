#pragma checksum "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99bb16d7a00a15d1fb686b2bdf7f81caf0557091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoaDons_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoaDons/Index.cshtml")]
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
#line 1 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99bb16d7a00a15d1fb686b2bdf7f81caf0557091", @"/Areas/Admin/Views/HoaDons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c81b1a8f9ef81bbd2ceef44ee517b11b3ebd31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoaDons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuaHangDienThoai.Models.View.HoaDonsPaging>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-default active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-primary active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::CuaHangDienThoai.TagHelpers.PageLinkTagHelper __CuaHangDienThoai_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
  
    ViewData["Title"] = "Danh sách hóa đơn";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2 class=\"text-info\" style=\"text-align:center\">Danh sách hóa đơn</h2>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bb16d7a00a15d1fb686b2bdf7f81caf05570916867", async() => {
                WriteLiteral(@"
    <div>
        <div style=""height:150px; background-color:aliceblue"" class=""container"">
            <div class=""row"" style=""padding-top:10px;"">
                <label>Tìm kiếm</label>
            </div>
            <div class=""col-12"">
                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                        Mã hóa đơn
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 21 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.Editor("searchMaHD", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                        Tên khách hàng
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 30 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.Editor("searchTenKH", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                </div>

                <div class=""row"" style=""padding-top:10px;"">
                    <div class=""col-2"">
                        Số điện thoại
                    </div>
                    <div class=""col-3"">
                        ");
#nullable restore
#line 40 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.Editor("searchSoDT", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-2"">

                    </div>
                    <div class=""col-2"">
                    </div>
                    <div class=""col-3"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-primary form-control"">
                            <i class=""fas fa-search""></i> Tìm kiếm
                        </button>
                    </div>

                </div>
            </div>
        </div>
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    ");
#nullable restore
#line 59 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().MaHD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 62 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().MaDH));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 65 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().TenKH));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 68 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().SoDT));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 71 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().GioiTinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 74 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().NgayLapHD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 77 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.HoaDons.FirstOrDefault().TongThanhToan));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n");
#nullable restore
#line 83 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
             foreach (var item in Model.HoaDons)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(m => item.MaHD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(m => item.MaDH));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 93 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(m => item.TenKH));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 96 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SoDT));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 99 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(m => item.GioiTinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 102 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                   Write(Html.DisplayFor(m => item.NgayLapHD));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <label class=\"form-text vnd\">");
#nullable restore
#line 105 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                                                Write(item.TongThanhToan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </td>\r\n                    <td style=\"width:150px\">\r\n                        <div class=\"btn-group\" role=\"group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bb16d7a00a15d1fb686b2bdf7f81caf055709115520", async() => {
                    WriteLiteral("\r\n                                <i class=\"far fa-list-alt\"></i>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MaHD", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
                                                                                              WriteLiteral(item.MaHD);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaHD"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MaHD", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaHD"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 115 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n        <div class=\"form-group d-flex justify-content-center\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bb16d7a00a15d1fb686b2bdf7f81caf055709118541", async() => {
                }
                );
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::CuaHangDienThoai.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__CuaHangDienThoai_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 119 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
__CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 119 "D:\SOEN\MobileStore_CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\HoaDons\Index.cshtml"
__CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __CuaHangDienThoai_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuaHangDienThoai.Models.View.HoaDonsPaging> Html { get; private set; }
    }
}
#pragma warning restore 1591
