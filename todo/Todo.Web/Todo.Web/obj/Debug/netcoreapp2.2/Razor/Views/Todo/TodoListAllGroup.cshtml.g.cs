#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c51bb0efd0e678def35725f3ef14ecab1782407"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_TodoListAllGroup), @"mvc.1.0.view", @"/Views/Todo/TodoListAllGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/TodoListAllGroup.cshtml", typeof(AspNetCore.Views_Todo_TodoListAllGroup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c51bb0efd0e678def35725f3ef14ecab1782407", @"/Views/Todo/TodoListAllGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_TodoListAllGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.TodoView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-arrow-alt-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Group", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Todo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTodo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
  
    ViewData["Title"] = "TodoListAllGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 6, true);
            WriteLiteral("<h1>  ");
            EndContext();
            BeginContext(158, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c51bb0efd0e678def35725f3ef14ecab17824075570", async() => {
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
            BeginContext(244, 34, true);
            WriteLiteral(" Task All Group </h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(278, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c51bb0efd0e678def35725f3ef14ecab17824077148", async() => {
                BeginContext(359, 11, true);
                WriteLiteral("Create Task");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(374, 366, true);
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
            <th class=""center-parent"" width=5%>
                Progress
            </th>
            <th width=5%>
                ");
            EndContext();
            BeginContext(741, 38, false);
#line 33 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(779, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=10% class=\"center-parent\">\r\n                ");
            EndContext();
            BeginContext(867, 46, false);
#line 36 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(913, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=85%>\r\n                ");
            EndContext();
            BeginContext(981, 44, false);
#line 40 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"center-parent\" width=5%>\r\n                ");
            EndContext();
            BeginContext(1112, 45, false);
#line 43 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 339, true);
            WriteLiteral(@"
            </th>
            <th class=""center-parent"" width=5%>
                Edit
            </th>
            <th class=""center-parent"" width=5%>
                Finish
            </th>
            <th class=""center-parent"" width=5%>
                Delete
            </th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 58 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1545, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1606, 43, false);
#line 62 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1672, 147, false);
#line 63 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "ProgressEdit", "Todo", new { id = item.ID }, new { @class = "fa fa-flag-checkered", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1887, 37, false);
#line 66 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1924, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2014, 45, false);
#line 69 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 71 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2156, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2215, 43, false);
#line 74 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 77 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2365, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(2441, 43, false);
#line 81 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2484, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 83 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2559, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2795, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 89 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2869, 223, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n                            ");
            EndContext();
            BeginContext(3093, 140, false);
#line 93 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-star-o", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(3233, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 96 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3340, 80, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(3421, 138, false);
#line 100 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-star", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(3559, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 102 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3634, 78, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(3713, 95, false);
#line 112 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "UpdateTodo", "Todo", new { id = item.ID }, new { @class = "fas fa-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(3808, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(3898, 145, false);
#line 115 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "FinishTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-flag-checkered", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(4043, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4133, 163, false);
#line 118 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "DeleteTodo", "Todo", new { id = item.ID }, new { @class = "fas fa-trash-alt", onclick = "return confirm('Bạn có muốn xóa To-to List này?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(4296, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 121 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
        }

#line default
#line hidden
            BeginContext(4351, 76, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
