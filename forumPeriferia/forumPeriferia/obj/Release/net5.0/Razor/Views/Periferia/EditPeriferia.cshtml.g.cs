#pragma checksum "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4611169628952f7dee30b70dcd8dc0a5b4247741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Periferia_EditPeriferia), @"mvc.1.0.view", @"/Views/Periferia/EditPeriferia.cshtml")]
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
#line 1 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\_ViewImports.cshtml"
using forumPeriferia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\_ViewImports.cshtml"
using forumPeriferia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\_ViewImports.cshtml"
using forumPeriferia.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4611169628952f7dee30b70dcd8dc0a5b4247741", @"/Views/Periferia/EditPeriferia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ee9029515821ca888167cc72858c20d91f4cd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Periferia_EditPeriferia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PerifernaChast>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Промени периферия</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4611169628952f7dee30b70dcd8dc0a5b42477414872", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"hidden\">\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Enter Content\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 194, "\"", 211, 1);
#nullable restore
#line 8 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml"
WriteAttributeValue("", 202, Model.Id, 202, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Име</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Enter Content\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 374, "\"", 393, 1);
#nullable restore
#line 13 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml"
WriteAttributeValue("", 382, Model.Name, 382, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>История</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Enter Content\" name=\"Istoria\"");
                BeginWriteAttribute("value", " value=\"", 563, "\"", 585, 1);
#nullable restore
#line 18 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml"
WriteAttributeValue("", 571, Model.Istoria, 571, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Класификация</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Enter Content\" name=\"Klasificatsia\"");
                BeginWriteAttribute("value", " value=\"", 764, "\"", 792, 1);
#nullable restore
#line 22 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml"
WriteAttributeValue("", 772, Model.Klasificatsia, 772, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Устроиство</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Enter Content\" name=\"Ustroistvo\"");
                BeginWriteAttribute("value", " value=\"", 966, "\"", 991, 1);
#nullable restore
#line 26 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml"
WriteAttributeValue("", 974, Model.Ustroistvo, 974, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Процес на деиствие</label>\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Enter Content\" name=\"ProcesNaDeisvie\"");
                BeginWriteAttribute("value", " value=\"", 1178, "\"", 1208, 1);
#nullable restore
#line 30 "D:\Калоян К - 12д\compstranitsa\forumPeriferia\forumPeriferia\Views\Periferia\EditPeriferia.cshtml"
WriteAttributeValue("", 1186, Model.ProcesNaDeisvie, 1186, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Edit</button>\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4611169628952f7dee30b70dcd8dc0a5b42477418704", async() => {
                    WriteLiteral("\r\n        <button type=\"button\" class=\"btn btn-secondary\">Cancel</button>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PerifernaChast> Html { get; private set; }
    }
}
#pragma warning restore 1591
