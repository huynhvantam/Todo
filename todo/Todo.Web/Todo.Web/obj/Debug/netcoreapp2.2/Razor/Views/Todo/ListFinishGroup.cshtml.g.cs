#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d790765ab68288bdce99a7522d32ac373ded5f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_ListFinishGroup), @"mvc.1.0.view", @"/Views/Todo/ListFinishGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/ListFinishGroup.cshtml", typeof(AspNetCore.Views_Todo_ListFinishGroup))]
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
#line 1 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web;

#line default
#line hidden
#line 2 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d790765ab68288bdce99a7522d32ac373ded5f3", @"/Views/Todo/ListFinishGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_ListFinishGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.TodoView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-arrow-alt-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Todo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodoListAllGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTodo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
  
    ViewData["Title"] = "ListFinishGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 6, true);
            WriteLiteral("<h1>  ");
            EndContext();
            BeginContext(157, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d790765ab68288bdce99a7522d32ac373ded5f35268", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            EndContext();
            BeginContext(253, 31, true);
            WriteLiteral(" Task Finish </h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(284, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d790765ab68288bdce99a7522d32ac373ded5f36843", async() => {
                BeginContext(365, 11, true);
                WriteLiteral("Create Task");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(380, 272, true);
            WriteLiteral(@"

</p>



<style>
    .textgach {
        font-weight: bold;
    }

    .center-parent {
        text-align: center;
    }
</style>

<table class=""table"" width=100%>
    <thead class=""thead-dark"">
        <tr>
            <th width=5%>
                ");
            EndContext();
            BeginContext(653, 38, false);
#line 30 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(691, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=10% class=\"center-parent\">\r\n                ");
            EndContext();
            BeginContext(779, 46, false);
#line 33 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(825, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=80%>\r\n                ");
            EndContext();
            BeginContext(893, 44, false);
#line 37 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(937, 151, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"center-parent\" width=5%>\r\n                Delete\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1089, 44, false);
#line 45 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.GroupIDG));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1245, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1306, 37, false);
#line 54 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(1433, 45, false);
#line 57 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 59 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(1575, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1634, 43, false);
#line 62 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 65 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1784, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(1860, 43, false);
#line 69 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 71 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1978, 66, true);
            WriteLiteral("\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2045, 169, false);
#line 75 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.ActionLink("", "DeleteTodoFinsih", "Todo", new { id = item.ID }, new { @class = "fas fa-trash-alt", onclick = "return confirm('Bạn có muốn xóa To-to List này?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2282, 43, false);
#line 78 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.GroupIDG));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 81 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
        }

#line default
#line hidden
            BeginContext(2380, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Todo.Web.Models.Todo.TodoView>> Html { get; private set; }
    }
}
#pragma warning restore 1591