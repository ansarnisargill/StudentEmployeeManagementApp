#pragma checksum "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fdac0ce4ddcfd0668023f9c70ea09751b9aa134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SmukToolsApp.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Details.cshtml", typeof(SmukToolsApp.Pages.Employees.Pages_Employees_Details), null)]
namespace SmukToolsApp.Pages.Employees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\_ViewImports.cshtml"
using SmukToolsApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdac0ce4ddcfd0668023f9c70ea09751b9aa134", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca41aa4b5c7fa92485e9584eaa7e2ab052c709e8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(113, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(243, 53, false);
#line 15 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Username));

#line default
#line hidden
            EndContext();
            BeginContext(296, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(358, 49, false);
#line 18 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Username));

#line default
#line hidden
            EndContext();
            BeginContext(407, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(468, 53, false);
#line 21 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Password));

#line default
#line hidden
            EndContext();
            BeginContext(521, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(583, 49, false);
#line 24 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Password));

#line default
#line hidden
            EndContext();
            BeginContext(632, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(693, 54, false);
#line 27 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(747, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(809, 50, false);
#line 30 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(859, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(920, 53, false);
#line 33 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(973, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1035, 49, false);
#line 36 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1145, 55, false);
#line 39 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeNo));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1262, 51, false);
#line 42 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeNo));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1374, 65, false);
#line 45 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.ContractStartingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1501, 61, false);
#line 48 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.ContractStartingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1623, 63, false);
#line 51 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.ContractEndingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1748, 59, false);
#line 54 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.ContractEndingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1868, 57, false);
#line 57 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeRole));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1987, 56, false);
#line 60 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeRole.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2090, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fdac0ce4ddcfd0668023f9c70ea09751b9aa13411077", async() => {
                BeginContext(2145, 4, true);
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
#line 65 "C:\Users\it\Desktop\StudentEmployeeManagementApp\Pages\Employees\Details.cshtml"
                           WriteLiteral(Model.Employee.ID);

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
            BeginContext(2153, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2161, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fdac0ce4ddcfd0668023f9c70ea09751b9aa13413406", async() => {
                BeginContext(2183, 12, true);
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
            BeginContext(2199, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeShiftManagement.Pages.Employees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeShiftManagement.Pages.Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeShiftManagement.Pages.Employees.DetailsModel>)PageContext?.ViewData;
        public EmployeeShiftManagement.Pages.Employees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591