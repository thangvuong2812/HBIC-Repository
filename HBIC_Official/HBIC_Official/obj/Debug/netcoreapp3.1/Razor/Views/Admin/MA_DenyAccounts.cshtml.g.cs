#pragma checksum "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a9dad321d7dc9e7c67117197abe36a363e1a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MA_DenyAccounts), @"mvc.1.0.view", @"/Views/Admin/MA_DenyAccounts.cshtml")]
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
#line 1 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\_ViewImports.cshtml"
using HBIC_Official;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\_ViewImports.cshtml"
using HBIC_Official.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a9dad321d7dc9e7c67117197abe36a363e1a3f", @"/Views/Admin/MA_DenyAccounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7020d4a823f9fe4c7c0cf5f2e772f7a83987fffb", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MA_DenyAccounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.BOAdmin_Deny>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/datatables-demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modal-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Quản lý tài khoản";

#line default
#line hidden
#nullable disable
            DefineSection("CssSection", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50a9dad321d7dc9e7c67117197abe36a363e1a3f6006", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ScriptsSection", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50a9dad321d7dc9e7c67117197abe36a363e1a3f7347", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50a9dad321d7dc9e7c67117197abe36a363e1a3f8446", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50a9dad321d7dc9e7c67117197abe36a363e1a3f9549", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n            let accountsJson = ");
#nullable restore
#line 21 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml"
                          Write(Html.Raw(Json.Serialize(Model.DenyUsers)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            var table = LoadDataToTable(accountsJson);
         
            var CheckOKPassInfoActionModal = (title, message,url) => {
                $(""#confirmActionModalLabel"").html(title);
                $(""#confirmActionModalBody"").html(message);
                $(""#confirmActionModal"").modal(""show"");
                $(""#confirmBtn"").click(function () {

                    window.location.href = url;
                });
            }

            //Approve button
            $('#dataTable-btn-multiapprove').click(function () {
                console.log(table.rows('.selected').data().pluck('userId').toArray());
                var userIds = table.rows('.selected').data().pluck('userId').toArray();

                var url = """);
#nullable restore
#line 39 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml"
                      Write(Url.Action("ApproveUsers", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" + \"?userIds=\" + userIds + \"&returnUrl=\" + \"");
#nullable restore
#line 39 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml"
                                                                                                       Write(Url.Action("MA_DenyAccounts", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                CheckOKPassInfoActionModal(""Duyệt"", ""Bạn có chắc muốn duyệt những tài khoản này?"", url);
            });
            //UnApprove button
            $('#dataTable-btn-multiunapprove').click(function () {
                console.log(table.rows('.selected').data().pluck('userId').toArray());
                var userIds = table.rows('.selected').data().pluck('userId').toArray();

                var url = """);
#nullable restore
#line 47 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml"
                      Write(Url.Action("UnApproveUsers", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" + \"?userIds=\" + userIds + \"&returnUrl=\" + \"");
#nullable restore
#line 47 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Admin\MA_DenyAccounts.cshtml"
                                                                                                         Write(Url.Action("MA_DenyAccounts", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                CheckOKPassInfoActionModal(""Chờ duyệt hàng loạt"", ""Bạn có chắc muốn đưa những tài khoản này về hàng chờ duyệt?"", url);
                /*    alert(table.rows('.selected').data().length + ' row(s) selected');*/
            });
        })
    </script>
");
            }
            );
            WriteLiteral(@"<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Tài khoản bị từ chối</h1>
    <button id=""btn-exportRp"" onclick=""capture()"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"">
        <i class=""fas fa-download fa-sm text-white-50""></i> Generate Report
    </button>
</div>

<!-- DataTales Example -->
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""d-inline-block m-0 font-weight-bold text-primary"">Danh sách tài khoản bị từ chối</h6>
        <div class=""d-md-inline-flex d-lg-inline-flex d-xl-inline-flex d-sm-inline-block justify-content-between align-items-center float-right"">
            <div class=""custom-control d-block custom-checkbox mb-sm-1 mb-lg-0 mb-md-0 mb-0 mr-xl-2 mr-lg-2 hov-pointer"">
                <input type=""checkbox"" class=""custom-control-input"" id=""selectAll-input"">
                <label class=""custom-control-label"" for=""selectAll-input"">Chọn t");
            WriteLiteral(@"ất cả</label>
            </div>
            <a href=""#"" id=""dataTable-btn-multiapprove"" class=""d-block btn btn-sm btn-success mr-xl-2 mr-md-2 mb-sm-2 mb-md-0 mb-xl-0 shadow-sm"">
                <i class=""fas fa-check-circle fa-sm text-white-50""></i> Duyệt hàng loạt
            </a>
            <a href=""#"" id=""dataTable-btn-multiunapprove"" class=""d-block btn btn-sm btn-warning shadow-sm"">
                <i class=""fas fa-chevron-circle-left fa-sm text-white-50""></i> Chờ duyệt hàng loạt
            </a>
        </div>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>

                        </th>
                        <th>Tên đăng nhập</th>
                        <th>Email</th>
                        <th>Loại đối tượng</th>
                        <th>Loại tài khoản</th>
                 ");
            WriteLiteral(@"       <th>Ngày tạo</th>

                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>

                        </th>
                        <th>Tên đăng nhập</th>
                        <th>Email</th>
                        <th>Loại đối tượng</th>
                        <th>Loại tài khoản</th>
                        <th>Ngày tạo</th>

                    </tr>
                </tfoot>
                <tbody>

                </tbody>
            </table>
        </div>
    </div>
</div>
<div id=""detail-info-modal"" class=""modal fade bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalLabel"">
                    Thông tin người dùng
                </h5>
                <button type=""button"" cla");
            WriteLiteral("ss=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50a9dad321d7dc9e7c67117197abe36a363e1a3f17456", async() => {
                WriteLiteral("\r\n                    <div id=\"modal-form-row\" class=\"form-row\">\r\n\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                <button type=""button"" class=""btn btn-primary"">Duyệt</button>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObject.BOAdmin_Deny> Html { get; private set; }
    }
}
#pragma warning restore 1591
