#pragma checksum "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ab9f0e09a6946810159df8ae1e77a9c09cfed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplyJob_Detailex), @"mvc.1.0.view", @"/Views/ApplyJob/Detailex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplyJob/Detailex.cshtml", typeof(AspNetCore.Views_ApplyJob_Detailex))]
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
#line 1 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\_ViewImports.cshtml"
using JobAppMS;

#line default
#line hidden
#line 3 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\_ViewImports.cshtml"
using JobAppMS.Models;

#line default
#line hidden
#line 4 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\_ViewImports.cshtml"
using JobAppMS.Models.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ab9f0e09a6946810159df8ae1e77a9c09cfed1", @"/Views/ApplyJob/Detailex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96197f94a7a7a65b8dfa8234d573c4f0151586de", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplyJob_Detailex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobAppMS.Models.Experience>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Getexinfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 4 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
  
    ViewData["Title"] = "Detailex";
    Layout = "~/Views/Shared/_Mylayout.cshtml";

#line default
#line hidden
            BeginContext(232, 289, true);
            WriteLiteral(@"
<div class=""row justify-content-sm-center modal modal-content modal-dialog-centered"">

    <div class=""col-md-12 align-self-center border border-success modal modal-content"">
        <h4 class=""align-content-center border font-weight-bold btn btn-success  ""> Education Details </h4>
");
            EndContext();
#line 13 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
            BeginContext(578, 109, true);
            WriteLiteral("            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(688, 44, false);
#line 18 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(732, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(818, 40, false);
#line 21 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(858, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(943, 47, false);
#line 24 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(990, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1076, 43, false);
#line 27 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1204, 51, false);
#line 30 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.CompanyBusiness));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1341, 47, false);
#line 33 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.CompanyBusiness));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1473, 47, false);
#line 36 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1606, 43, false);
#line 39 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1734, 46, false);
#line 42 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1866, 42, false);
#line 45 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1993, 45, false);
#line 48 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.startDate));

#line default
#line hidden
            EndContext();
            BeginContext(2038, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2124, 41, false);
#line 51 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.startDate));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2250, 43, false);
#line 54 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2293, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2379, 39, false);
#line 57 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2503, 41, false);
#line 60 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayNameFor(model => model.Skill));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2630, 37, false);
#line 63 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
               Write(Html.DisplayFor(model => model.Skill));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 44, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
            EndContext();
#line 66 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Detailex.cshtml"
        }

#line default
#line hidden
            BeginContext(2722, 45, true);
            WriteLiteral("        </div>\r\n        <div>\r\n\r\n            ");
            EndContext();
            BeginContext(2767, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41ab9f0e09a6946810159df8ae1e77a9c09cfed113468", async() => {
                BeginContext(2814, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(2830, 50, true);
            WriteLiteral("\r\n            <br />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobAppMS.Models.Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591