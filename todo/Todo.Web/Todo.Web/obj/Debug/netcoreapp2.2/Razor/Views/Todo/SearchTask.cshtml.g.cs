#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cadc67835dbbdd7f39d8dc65a670328e789311c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_SearchTask), @"mvc.1.0.view", @"/Views/Todo/SearchTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/SearchTask.cshtml", typeof(AspNetCore.Views_Todo_SearchTask))]
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
#line 1 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web;

#line default
#line hidden
#line 2 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cadc67835dbbdd7f39d8dc65a670328e789311c", @"/Views/Todo/SearchTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_SearchTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.SearchTask>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
  
    ViewData["Title"] = "SearchTask";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 34, true);
            WriteLiteral("\r\n<h1>SearchTask</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(182, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cadc67835dbbdd7f39d8dc65a670328e789311c3933", async() => {
                BeginContext(205, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(219, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(312, 38, false);
#line 17 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(350, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(406, 44, false);
#line 20 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(450, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(506, 45, false);
#line 23 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(607, 46, false);
#line 26 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(653, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(709, 44, false);
#line 29 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.GroupIDG));

#line default
#line hidden
            EndContext();
            BeginContext(753, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(809, 42, false);
#line 32 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.Finish));

#line default
#line hidden
            EndContext();
            BeginContext(851, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(907, 44, false);
#line 35 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayNameFor(model => model.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(951, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1069, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1118, 37, false);
#line 44 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1211, 43, false);
#line 47 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1310, 44, false);
#line 50 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.Important));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1410, 45, false);
#line 53 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1511, 43, false);
#line 56 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.GroupIDG));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1610, 41, false);
#line 59 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.Finish));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1707, 43, false);
#line 62 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1806, 65, false);
#line 65 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1892, 71, false);
#line 66 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1984, 69, false);
#line 67 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2053, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\SearchTask.cshtml"
}

#line default
#line hidden
            BeginContext(2092, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Todo.Web.Models.Todo.SearchTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591