#pragma checksum "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031d48c9395cc23286bafc8e5be9a6b732125643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AccountTypesViews__GA_Coporation), @"mvc.1.0.view", @"/Views/Shared/AccountTypesViews/_GA_Coporation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031d48c9395cc23286bafc8e5be9a6b732125643", @"/Views/Shared/AccountTypesViews/_GA_Coporation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7020d4a823f9fe4c7c0cf5f2e772f7a83987fffb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AccountTypesViews__GA_Coporation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.BOUserInfo>
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
#line 5 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
  

    var selectedSpecialityGroup = new SelectList(ViewBag.SpecialiyGroups).FirstOrDefault(o => o.Value == Model.SpecialityGroupId.ToString());

    var selectedSpeciality = new SelectList(ViewBag.Specialities).FirstOrDefault(o => o.Value == Model.SpecialityId.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12\">\r\n    <h2>Tập đoàn</h2>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 17 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.GroupCompanyName, "Tên tổ chức"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 19 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.GroupCompanyName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 25 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.WebsiteAddress, "Website"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 27 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.WebsiteAddress, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 33 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.EstablishYear, "Năm thành lập"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 35 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.EstablishYear, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 41 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.Address, "Địa chỉ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 43 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.Address, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 49 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.FullName, "Tên người đại diện liên hệ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 51 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.FullName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 57 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.Telephone, "SĐT người liên hệ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 59 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.Telephone, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 65 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.TaxCode, "Mã số thuế"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 67 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.TaxCode, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 74 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.TaxCodeTime, "Ngày cấp mã số thuế"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 76 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.TaxCodeTime, "{0:yyyy-MM-dd}", new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 82 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.Department, "Tên bộ phận"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 84 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.Department, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 90 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.LabelFor(model => model.Email, "Email liên hệ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 92 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div class=""col-12"">
    <label for=""sltDetailSpecialzes"">Lĩnh vực đầu tư</label>
</div>
<div class=""col-xl-4 col-md-4 col-sm-12"">
    <div class=""custom-control custom-checkbox"">
        <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
        <label class=""custom-control-label"" for=""customCheck1"">Cho thuê phòng máy móc, thiết bị</label>
    </div>
</div>
<div class=""col-xl-4 col-md-4 col-sm-12"">
    <div class=""custom-control custom-checkbox"">
        <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"">
        <label class=""custom-control-label"" for=""customCheck2"">Nhận dự án từ thành viên của hệ sinh thái HBIC</label>
    </div>
</div>
<div class=""col-xl-4 col-md-4 col-sm-12"">
    <div class=""custom-control custom-checkbox"">
        <input type=""checkbox"" class=""custom-control-input"" id=""customCheck3"">
        <label class=""custom-control-label"" for=""customCheck3"">Thuê mặt bằng trong HBIC-SHTP trong tương lai</label>
    </d");
            WriteLiteral(@"iv>
</div>
<div class=""col-xl-6 col-md-6 col-sm-12"">
    <label for=""sltInvestmentFundTypes"">Loại đầu tư</label>
    <select id=""sltInvestmentFundTypes"" class=""form-select form-group w-100"">
    </select>
</div>


<div class=""col-12"">
    <label for=""inputLastName"">Hợp tác với HBIC</label>
</div>
");
#nullable restore
#line 127 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
   for (int i = 0; i < Model.FieldHbicCoops.Count(); i++)
    {
        var id = Model.FieldHbicCoops[i].Value;
        var name = Model.FieldHbicCoops[i].Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n            <div class=\"custom-control form-group custom-checkbox\">\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "031d48c9395cc23286bafc8e5be9a6b73212564314766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 134 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031d48c9395cc23286bafc8e5be9a6b73212564316587", async() => {
#nullable restore
#line 136 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
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
#line 136 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "031d48c9395cc23286bafc8e5be9a6b73212564318474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 137 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "031d48c9395cc23286bafc8e5be9a6b73212564320177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 138 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
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
#line 141 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_Coporation.cshtml"
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
