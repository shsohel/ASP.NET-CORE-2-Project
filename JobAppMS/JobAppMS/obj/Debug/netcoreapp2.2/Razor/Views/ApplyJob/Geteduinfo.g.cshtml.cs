#pragma checksum "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809fdbc0e330f85b61f23108fb6ca286315c09bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplyJob_Geteduinfo), @"mvc.1.0.view", @"/Views/ApplyJob/Geteduinfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplyJob/Geteduinfo.cshtml", typeof(AspNetCore.Views_ApplyJob_Geteduinfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809fdbc0e330f85b61f23108fb6ca286315c09bf", @"/Views/ApplyJob/Geteduinfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96197f94a7a7a65b8dfa8234d573c4f0151586de", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplyJob_Geteduinfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobAppMS.Models.Education>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detailedu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deleteedu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Getexinfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
  
    ViewData["Title"] = "Geteduinfo";
    Layout = "~/Views/Shared/_Mylayout.cshtml";

#line default
#line hidden
            BeginContext(246, 286, true);
            WriteLiteral(@"
<div class=""row justify-content-sm-center modal modal-content modal-dialog-centered"">

    <div class=""col-md-12 align-self-center border border-success modal modal-content"">
        <h4 class=""align-content-center border font-weight-bold btn btn-success  ""> Education Info </h4>
");
            EndContext();
#line 13 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
            BeginContext(589, 144, true);
            WriteLiteral("            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(734, 44, false);
#line 19 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(778, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(870, 51, false);
#line 22 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.ExamDegreeTitle));

#line default
#line hidden
            EndContext();
            BeginContext(921, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1013, 53, false);
#line 25 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.GroupMajorSubject));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1158, 55, false);
#line 28 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.InstituteUniversity));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1305, 42, false);
#line 31 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.Result));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1439, 40, false);
#line 34 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.CGPA));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1571, 41, false);
#line 37 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.Scale));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1704, 49, false);
#line 40 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.YearOfPassing));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1845, 44, false);
#line 43 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 146, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2108, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2205, 43, false);
#line 53 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2352, 50, false);
#line 56 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ExamDegreeTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2506, 52, false);
#line 59 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GroupMajorSubject));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2662, 54, false);
#line 62 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.InstituteUniversity));

#line default
#line hidden
            EndContext();
            BeginContext(2716, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2820, 41, false);
#line 65 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Result));

#line default
#line hidden
            EndContext();
            BeginContext(2861, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2965, 39, false);
#line 68 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CGPA));

#line default
#line hidden
            EndContext();
            BeginContext(3004, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3108, 40, false);
#line 71 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Scale));

#line default
#line hidden
            EndContext();
            BeginContext(3148, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3252, 48, false);
#line 74 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.YearOfPassing));

#line default
#line hidden
            EndContext();
            BeginContext(3300, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3404, 43, false);
#line 77 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(3447, 137, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                \r\n                                ");
            EndContext();
            BeginContext(3584, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809fdbc0e330f85b61f23108fb6ca286315c09bf16795", async() => {
                BeginContext(3658, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                                                                                 WriteLiteral(item.EduID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3669, 75, true);
            WriteLiteral(" \r\n                                <br />\r\n                                ");
            EndContext();
            BeginContext(3744, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809fdbc0e330f85b61f23108fb6ca286315c09bf19366", async() => {
                BeginContext(3820, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                                                                                   WriteLiteral(item.EduID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3830, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 86 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
                    }

#line default
#line hidden
            BeginContext(3921, 134, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div>\r\n                <div class=\"mfp-arrow-right\">\r\n                    ");
            EndContext();
            BeginContext(4055, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809fdbc0e330f85b61f23108fb6ca286315c09bf22363", async() => {
                BeginContext(4144, 17, true);
                WriteLiteral(" Experrience Info");
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
            BeginContext(4165, 70, true);
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n            </div>\r\n");
            EndContext();
#line 95 "C:\Users\IDB_C#\Downloads\MT09ExamProjec_Sakhawat_1246665\1246665\JobAppMS\JobAppMS\Views\ApplyJob\Geteduinfo.cshtml"
        }

#line default
#line hidden
            BeginContext(4246, 22, true);
            WriteLiteral("        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobAppMS.Models.Education>> Html { get; private set; }
    }
}
#pragma warning restore 1591
