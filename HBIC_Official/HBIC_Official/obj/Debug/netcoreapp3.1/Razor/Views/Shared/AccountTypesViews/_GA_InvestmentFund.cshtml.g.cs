#pragma checksum "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4db6f4f29362b239441493da985cab06e64906d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AccountTypesViews__GA_InvestmentFund), @"mvc.1.0.view", @"/Views/Shared/AccountTypesViews/_GA_InvestmentFund.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db6f4f29362b239441493da985cab06e64906d5", @"/Views/Shared/AccountTypesViews/_GA_InvestmentFund.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7020d4a823f9fe4c7c0cf5f2e772f7a83987fffb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AccountTypesViews__GA_InvestmentFund : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObject.BOUserInfo>
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
#line 5 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
  

    //var selectedSpecialityGroup = new SelectList(ViewBag.SpecialiyGroups).FirstOrDefault(o => o.Value == Model.SpecialityGroupId.ToString());

    //var selectedSpeciality = new SelectList(ViewBag.Specialities).FirstOrDefault(o => o.Value == Model.SpecialityId.ToString());
    var investmentTypes = Model.InvestmentTypes;
    var investmentSpecs = Model.InvestmentSpecs;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12\">\r\n    <h2>Quỹ đầu tư</h2>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 19 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.GroupCompanyName, "Tên tổ chức", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.GroupCompanyName, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 26 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.WebsiteAddress, "Địa chỉ website", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.WebsiteAddress, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 33 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.EstablishYear, "Năm thành lập", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.EstablishYear, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 40 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.Address, "Địa chỉ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 41 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.Address, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 47 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.FullName, "Tên người đại diện liên hệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.FullName, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 54 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.Telephone, "SĐT người liên hệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 55 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.Telephone, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 61 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.TaxCode, "Mã số thuế", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 62 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.TaxCode, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 68 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.TaxCodeTime, "Ngày cấp mã số thuế", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 69 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.TaxCodeTime, "{0:yyyy-MM-dd}", new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 74 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.Department, "Tên bộ phận", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 75 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.Department, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"col-xl-6 col-md-6 col-sm-12\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 80 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.LabelFor(model => model.Email, "Email liên hệ", new { @class = "font-weight-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 81 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control", type = "text", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<div class=\"col-12\">\r\n    <label class=\"font-weight-bold\" for=\"sltInvestmentFundTypes\">Lĩnh vực đầu tư</label>\r\n    <div class=\"form-row\">\r\n");
#nullable restore
#line 98 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
           for (int i = 0; i < investmentSpecs.Count(); i++)
            {
                var id = investmentSpecs[i].Value;
                var name = investmentSpecs[i].Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-3 col-md-3 col-sm-6\">\r\n                    <div class=\"custom-control form-group custom-checkbox\">\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4db6f4f29362b239441493da985cab06e64906d514273", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 105 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentSpecs[i].Selected);

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
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4db6f4f29362b239441493da985cab06e64906d516101", async() => {
#nullable restore
#line 107 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
#line 107 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentSpecs[i].Selected);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4db6f4f29362b239441493da985cab06e64906d518002", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 108 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentSpecs[i].Value);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4db6f4f29362b239441493da985cab06e64906d519712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 109 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentSpecs[i].Text);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 112 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n<div class=\"col-12\">\r\n    <label class=\"font-weight-bold\" for=\"sltInvestmentFundTypes\">Quỹ đầu tư</label>\r\n    <div class=\"form-row\">\r\n\r\n");
#nullable restore
#line 122 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
           for (int i = 0; i < investmentTypes.Count(); i++)
            {
                var id = investmentTypes[i].Value;
                var name = investmentTypes[i].Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n                    <div class=\"custom-control form-group custom-checkbox\">\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4db6f4f29362b239441493da985cab06e64906d522504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 129 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentTypes[i].Selected);

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
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4db6f4f29362b239441493da985cab06e64906d524332", async() => {
#nullable restore
#line 131 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
#line 131 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentTypes[i].Selected);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4db6f4f29362b239441493da985cab06e64906d526233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 132 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentTypes[i].Value);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4db6f4f29362b239441493da985cab06e64906d527943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 133 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => investmentTypes[i].Text);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 136 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"col-12\">\r\n    <label class=\"font-weight-bold\" for=\"inputLastName\">Hợp tác với HBIC</label>\r\n</div>\r\n");
#nullable restore
#line 147 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
   for (int i = 0; i < Model.FieldHbicCoops.Count(); i++)
    {
        var id = Model.FieldHbicCoops[i].Value;
        var name = Model.FieldHbicCoops[i].Text;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-4 col-md-4 col-sm-12\">\r\n            <div class=\"custom-control form-group custom-checkbox\">\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4db6f4f29362b239441493da985cab06e64906d530673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 154 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4db6f4f29362b239441493da985cab06e64906d532498", async() => {
#nullable restore
#line 156 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
#line 156 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4db6f4f29362b239441493da985cab06e64906d534393", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 157 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4db6f4f29362b239441493da985cab06e64906d536100", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 158 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
#line 161 "E:\XamarinForms\Git\HBIC_Portal\HBIC_Official\HBIC_Official\Views\Shared\AccountTypesViews\_GA_InvestmentFund.cshtml"
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
