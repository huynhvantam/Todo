#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3fe73f7329676f63e0ba7d090574b656c5dfad5"
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
#line 1 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web;

#line default
#line hidden
#line 2 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fe73f7329676f63e0ba7d090574b656c5dfad5", @"/Views/Todo/TodoListAllGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_TodoListAllGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.TodoView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-arrow-alt-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Group", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Todo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTodo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodoListAllGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
  
    ViewData["Title"] = "TodoListAllGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 6, true);
            WriteLiteral("<h1>  ");
            EndContext();
            BeginContext(158, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3fe73f7329676f63e0ba7d090574b656c5dfad56477", async() => {
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
            BeginContext(244, 161, true);
            WriteLiteral(" Todo All Group </h1>\r\n<div class=\"row\"></div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(405, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3fe73f7329676f63e0ba7d090574b656c5dfad58197", async() => {
                BeginContext(486, 11, true);
                WriteLiteral("Create Todo");
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
            BeginContext(501, 125, true);
            WriteLiteral("\r\n\r\n            </p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-inline\">\r\n                ");
            EndContext();
            BeginContext(626, 308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3fe73f7329676f63e0ba7d090574b656c5dfad510001", async() => {
                BeginContext(697, 230, true);
                WriteLiteral("\r\n                    <input class=\"form-control \" type=\"search\" placeholder=\"Search....\" aria-label=\"task\" name=\"task\">\r\n                    <button class=\"btn btn-outline-success \" type=\"submit\">Search</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(934, 62, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1020, 17, false);
#line 30 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
Write(ViewBag.VGgroupid);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1064, 478, true);
            WriteLiteral(@"

<style>
    #colorcornflowerblue {
        color: cornflowerblue;
    }

    #colorblack {
        color: black;
    }

    #colorgreen {
        color: green;
    }

    #colorred {
        color: red;
    }

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
            BeginContext(1543, 38, false);
#line 64 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=10% class=\"center-parent\">\r\n                ");
            EndContext();
            BeginContext(1669, 46, false);
#line 67 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=80%>\r\n                ");
            EndContext();
            BeginContext(1783, 44, false);
#line 71 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 154, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=12%>\r\n                Add\r\n            </th>\r\n            <th class=\"center-parent\" width=5%>\r\n                ");
            EndContext();
            BeginContext(1982, 45, false);
#line 77 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(2027, 435, true);
            WriteLiteral(@"
            </th>
            <th class=""center-parent"" width=3%>
                Edit
            </th>

            <th class=""center-parent"" width=5%>
                Progress
            </th>
            <th class=""center-parent"" width=2%>
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
#line 96 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2511, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2572, 37, false);
#line 100 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2699, 45, false);
#line 103 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 105 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2841, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2900, 43, false);
#line 108 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2943, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 111 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3050, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(3126, 43, false);
#line 115 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(3169, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 117 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3244, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(3287, 128, false);
#line 120 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "Index", "ListTodo", new { id = item.ID }, new { @id = "colorcornflowerblue", @class = "fas fa-book-open" }));

#line default
#line hidden
            EndContext();
            BeginContext(3415, 23, true);
            WriteLiteral("\r\n                    (");
            EndContext();
            BeginContext(3439, 48, false);
#line 121 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                Write(Html.DisplayFor(modelItem => item.AllListFinish));

#line default
#line hidden
            EndContext();
            BeginContext(3487, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(3489, 42, false);
#line 121 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.AllList));

#line default
#line hidden
            EndContext();
            BeginContext(3531, 26, true);
            WriteLiteral(")\r\n                </td>\r\n");
            EndContext();
#line 123 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(3629, 223, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n                            ");
            EndContext();
            BeginContext(3853, 99, false);
#line 127 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-star-o" }));

#line default
#line hidden
            EndContext();
            BeginContext(3952, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 129 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4057, 80, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(4138, 97, false);
#line 133 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-star" }));

#line default
#line hidden
            EndContext();
            BeginContext(4235, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 135 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(4310, 64, true);
            WriteLiteral("                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4375, 115, false);
#line 138 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "UpdateTodo", "Todo", new { id = item.ID }, new { @id = "colorgreen", @class = "fas fa-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(4490, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4558, 43, false);
#line 141 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(4601, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4624, 135, false);
#line 142 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "ProgressEdit", "Todo", new { id = item.ID }, new { @id = "colorcornflowerblue", @class = "fa fa-flag-checkered" }));

#line default
#line hidden
            EndContext();
            BeginContext(4759, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4849, 182, false);
#line 145 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "FinishTodo", "Todo", new { id = item.ID }, new { @id = "colorred", @class = "fa fa-flag-checkered", onclick = "return confirm('Are you sure to finish todo?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(5031, 66, true);
            WriteLiteral("\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(5098, 180, false);
#line 147 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "DeleteTodo", "Todo", new { id = item.ID }, new { @id = "colorblack", @class = "fas fa-trash-alt", onclick = "return confirm('Are you sure to delete todo?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(5278, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 150 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
        }

#line default
#line hidden
            BeginContext(5333, 76, true);
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
