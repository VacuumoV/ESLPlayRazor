#pragma checksum "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da25310c670452a64b3faae11916fe6947cb172d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PlayESLRazor.Pages.CompTeams.Pages_CompTeams_Details), @"mvc.1.0.razor-page", @"/Pages/CompTeams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CompTeams/Details.cshtml", typeof(PlayESLRazor.Pages.CompTeams.Pages_CompTeams_Details), @"{id:int?}")]
namespace PlayESLRazor.Pages.CompTeams
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\_ViewImports.cshtml"
using PlayESLRazor;

#line default
#line hidden
#line 3 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\_ViewImports.cshtml"
using PlayESLRazor.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da25310c670452a64b3faae11916fe6947cb172d", @"/Pages/CompTeams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a9b9be05fb0b95078c21958c00b3f0d560e7a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CompTeams_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
  
    ViewData["Title"] = "Details Of The Competing Team";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(183, 188, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Competing Teams</h4>\r\n    <hr style=\"color: black; background-color:black; height: 1px;\" />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(372, 49, false);
#line 16 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompTeam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(465, 45, false);
#line 19 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompTeam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(510, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(554, 59, false);
#line 22 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompTeam.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(613, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(657, 55, false);
#line 25 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompTeam.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(756, 56, false);
#line 28 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompTeam.Enrollments));

#line default
#line hidden
            EndContext();
            BeginContext(812, 204, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>Tournament Title</th>\r\n                    <th>Tournament Tier</th>\r\n                </tr>\r\n");
            EndContext();
#line 36 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
                 foreach (var item in Model.CompTeam.Enrollments)
                {

#line default
#line hidden
            BeginContext(1102, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1187, 51, false);
#line 40 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tournament.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1330, 50, false);
#line 43 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tournament.Tier));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 46 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1459, 67, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1526, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "875bcdd54e4d4a4a9addb25a7932f8ee", async() => {
                BeginContext(1589, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\Repos\PlayESLRazor\PlayESLRazor\Pages\CompTeams\Details.cshtml"
                           WriteLiteral(Model.CompTeam.CompTeamId);

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
            BeginContext(1597, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1605, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de0c4bd6c1944a785fafc107287a85c", async() => {
                BeginContext(1627, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1643, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayESLRazor.Pages.CompTeams.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayESLRazor.Pages.CompTeams.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayESLRazor.Pages.CompTeams.DetailsModel>)PageContext?.ViewData;
        public PlayESLRazor.Pages.CompTeams.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
