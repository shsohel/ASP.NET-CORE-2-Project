#pragma checksum "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb857ba1f3b03fe168fed91adaa368a3791b7bcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplyJob_Getexinfo), @"mvc.1.0.view", @"/Views/ApplyJob/Getexinfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplyJob/Getexinfo.cshtml", typeof(AspNetCore.Views_ApplyJob_Getexinfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb857ba1f3b03fe168fed91adaa368a3791b7bcd", @"/Views/ApplyJob/Getexinfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96197f94a7a7a65b8dfa8234d573c4f0151586de", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplyJob_Getexinfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobAppMS.Models.Experience>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detailex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deleteex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Gettraininfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ApplyJob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
  
    ViewData["Title"] = "Getexinfo";
    Layout = "~/Views/Shared/_Mylayout.cshtml";

#line default
#line hidden
            BeginContext(246, 287, true);
            WriteLiteral(@"
<div class=""row justify-content-sm-center modal modal-content modal-dialog-centered"">

    <div class=""col-md-12 align-self-center border border-success modal modal-content"">
        <h4 class=""align-content-center border font-weight-bold btn btn-success  ""> Experience Info </h4>
");
            EndContext();
#line 13 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
            BeginContext(590, 144, true);
            WriteLiteral("            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(735, 44, false);
#line 19 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(779, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(871, 47, false);
#line 22 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(918, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1010, 51, false);
#line 25 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.CompanyBusiness));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1153, 47, false);
#line 28 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1292, 46, false);
#line 31 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1430, 45, false);
#line 34 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.startDate));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1567, 43, false);
#line 37 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1702, 41, false);
#line 40 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.Skill));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 146, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1962, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2059, 43, false);
#line 50 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2102, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2206, 46, false);
#line 53 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2356, 50, false);
#line 56 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CompanyBusiness));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2510, 46, false);
#line 59 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2660, 45, false);
#line 62 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2809, 44, false);
#line 65 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.startDate));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2957, 42, false);
#line 68 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2999, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3103, 40, false);
#line 71 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Skill));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3246, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb857ba1f3b03fe168fed91adaa368a3791b7bcd15685", async() => {
                BeginContext(3326, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                                                           WriteLiteral(item.ExperienceID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3337, 74, true);
            WriteLiteral("\r\n                                <br />\r\n                                ");
            EndContext();
            BeginContext(3411, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb857ba1f3b03fe168fed91adaa368a3791b7bcd18239", async() => {
                BeginContext(3493, 6, true);
                WriteLiteral("Delete");
                EndContext();
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
#line 76 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                                                           WriteLiteral(item.ExperienceID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3503, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 79 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
                    }

#line default
#line hidden
            BeginContext(3594, 134, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div>\r\n                <div class=\"mfp-arrow-right\">\r\n                    ");
            EndContext();
            BeginContext(3728, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb857ba1f3b03fe168fed91adaa368a3791b7bcd21217", async() => {
                BeginContext(3820, 14, true);
                WriteLiteral(" Training Info");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3838, 70, true);
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n            </div>\r\n");
            EndContext();
#line 88 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Getexinfo.cshtml"
        }

#line default
#line hidden
            BeginContext(3919, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobAppMS.Models.Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
