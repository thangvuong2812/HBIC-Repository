#pragma checksum "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f117c380699741ef8ab8c45225ea9dc7d527e39a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AccountTypesViews__GA_StartupFirm), @"mvc.1.0.view", @"/Views/Shared/AccountTypesViews/_GA_StartupFirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f117c380699741ef8ab8c45225ea9dc7d527e39a", @"/Views/Shared/AccountTypesViews/_GA_StartupFirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7020d4a823f9fe4c7c0cf5f2e772f7a83987fffb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AccountTypesViews__GA_StartupFirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.BOUserInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
  

    var selectedSpecialityGroup = new SelectList(ViewBag.SpecialiyGroups).FirstOrDefault(o => o.Value == Model.SpecialityGroupId.ToString());

    var selectedSpeciality = new SelectList(ViewBag.Specialities).FirstOrDefault(o => o.Value == Model.SpecialityId.ToString());
    //var countries = (List<SelectListItem>)ViewBag.Countries;
    //SelectListItem selectedCountry = new SelectListItem();
    //if (Model.Country !=null)
    //    selectedCountry = countries.Where(o => o.Value.ToLower() == Model.Country.ToLower()).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12\">\r\n    <h2>Công ty khởi nghiệp</h2>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 22 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.GroupCompanyName, "Tên tổ chức", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.GroupCompanyName, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.GroupCompanyName, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 31 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.WebsiteAddress, "Địa chỉ website", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.WebsiteAddress, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.WebsiteAddress, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 40 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.EstablishYear, "Năm thành lập", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 41 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.EstablishYear, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.EstablishYear, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 49 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 50 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.Address, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 51 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.Address, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 58 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.FullName, "Tên người đại diện liên hệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 59 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.FullName, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 60 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.FullName, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 67 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.Telephone, "SĐT người liên hệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 68 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.Telephone, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 69 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.Telephone, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 76 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.TaxCode, "Mã số thuế", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 77 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.TaxCode, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 78 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.TaxCode, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 86 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.TaxCodeTime, "Ngày cấp mã số thuế", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 87 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.TaxCodeTime, "{0:yyyy-MM-dd}", new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 93 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.Department, "Tên bộ phận", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 94 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.Department, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 100 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.Email, "Email liên hệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 101 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 102 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.ValidationMessageFor(model => model.Email, string.Empty, new { @class = "invalid-feedback" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <label class=\"font-weight-bold\" for=\"sltSpecializaGroup\">Lĩnh vực kinh doanh</label>\r\n    ");
#nullable restore
#line 109 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
Write(Html.DropDownListFor(model => model.SpecialityGroupId, new SelectList(ViewBag.SpecialiyGroups, "Value", "Text", selectedSpecialityGroup), new { @class = "form-select form-group w-100", @id = "sltSpecialityGroup", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <label class=\"font-weight-bold\" for=\"sltDetailSpecialzes\">Chi tiết lĩnh vực kinh doanh</label>\r\n    ");
#nullable restore
#line 113 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
Write(Html.DropDownListFor(model => model.SpecialityId, new SelectList(ViewBag.Specialities, "Value", "Text", selectedSpeciality), new { @class = "form-select form-group w-100", @id = "sltSpeciality", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 119 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.MobilizedCapital, "Vốn huy động", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"input-group\">\r\n\r\n            ");
#nullable restore
#line 122 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
       Write(Html.TextBoxFor(model => model.MobilizedCapital, new { @class = "form-control", @type = Model.IsHideMobilizedCapital == true ? "password" : "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"input-group-append\">\r\n                <div class=\"input-group-text\">\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 127 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
               Write(Html.CheckBox(nameof(Model.IsHideMobilizedCapital), Model.IsHideMobilizedCapital, new { @class = "chkHidField" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 136 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.AuthorizedCapital, "Vốn điều lệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"input-group\">\r\n\r\n            ");
#nullable restore
#line 139 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
       Write(Html.TextBoxFor(model => model.AuthorizedCapital, new { @class = "form-control", @type = Model.IsHideAuthorizedCapital == true ? "password" : "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"input-group-append\">\r\n                <div class=\"input-group-text\">\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 144 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
               Write(Html.CheckBox(nameof(Model.IsHideAuthorizedCapital), Model.IsHideAuthorizedCapital, new { @class = "chkHidField" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 154 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.AttendeeNumber, "Số lượng nhân viên", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 155 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.AttendeeNumber, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 161 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.FirstProductTime, "Thời điểm ra mắt sản phẩm đầu tiên?", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 162 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.TextBoxFor(model => model.FirstProductTime, "{0:yyyy-MM-dd}", new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n    <div class=\"custom-control form-group custom-checkbox\">\r\n\r\n        ");
#nullable restore
#line 191 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.CheckBox(nameof(Model.IsHardLookPartner), Model.IsHardLookPartner, new { @class = "custom-control-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 192 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.IsHardLookPartner, new { @class = "custom-control-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n    <div class=\"custom-control form-group custom-checkbox\">\r\n\r\n        ");
#nullable restore
#line 199 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.CheckBox(nameof(Model.IsNeedAdvisory), Model.IsNeedAdvisory , new { @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 200 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.IsNeedAdvisory, new { @class = "custom-control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n    <div class=\"custom-control form-group custom-checkbox\">\r\n        ");
#nullable restore
#line 205 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.CheckBox(nameof(Model.IsNeedHired), Model.IsNeedHired, new { @class = "custom-control-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 207 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   Write(Html.LabelFor(model => model.IsNeedHired, new { @class = "custom-control-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"col-12\">\r\n    <label class=\"font-weight-bold\" for=\"inputLastName\">Hợp tác với HBIC</label>\r\n</div>\r\n");
#nullable restore
#line 215 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
   for (int i = 0; i < Model.FieldHbicCoops.Count(); i++)
    {
        var id = Model.FieldHbicCoops[i].Value;
        var name = Model.FieldHbicCoops[i].Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n            <div class=\"custom-control form-group custom-checkbox\">\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f117c380699741ef8ab8c45225ea9dc7d527e39a25613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 222 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FieldHbicCoops[i].Selected);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f117c380699741ef8ab8c45225ea9dc7d527e39a27435", async() => {
#nullable restore
#line 224 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
                                                                                           Write(name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 224 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FieldHbicCoops[i].Selected);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f117c380699741ef8ab8c45225ea9dc7d527e39a29324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 225 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FieldHbicCoops[i].Value);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f117c380699741ef8ab8c45225ea9dc7d527e39a31028", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 226 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FieldHbicCoops[i].Text);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 229 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_StartupFirm.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObject.BOUserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
