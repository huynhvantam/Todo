#pragma checksum "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17a0bc61d2a217a2ff43f974d9d7412960941cd3"
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
#line 1 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a0bc61d2a217a2ff43f974d9d7412960941cd3", @"/Views/Todo/TodoListAllGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_TodoListAllGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.TodoView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-arrow-alt-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Group", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Todo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTodo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
  
    ViewData["Title"] = "TodoListAllGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 6, true);
            WriteLiteral("<h1>  ");
            EndContext();
            BeginContext(158, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17a0bc61d2a217a2ff43f974d9d7412960941cd36146", async() => {
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
            WriteLiteral(" Task All Group </h1>\r\n<div class=\"row\"></div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(405, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17a0bc61d2a217a2ff43f974d9d7412960941cd37866", async() => {
                BeginContext(486, 11, true);
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
            BeginContext(501, 125, true);
            WriteLiteral("\r\n\r\n            </p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-inline\">\r\n                ");
            EndContext();
            BeginContext(626, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17a0bc61d2a217a2ff43f974d9d7412960941cd39670", async() => {
                BeginContext(686, 230, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(923, 322, true);
            WriteLiteral(@"
            </div>

        </div>
    </div>
</div>


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
            BeginContext(1246, 38, false);
#line 45 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=10% class=\"center-parent\">\r\n                ");
            EndContext();
            BeginContext(1372, 46, false);
#line 48 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=85%>\r\n                ");
            EndContext();
            BeginContext(1486, 44, false);
#line 52 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"center-parent\" width=5%>\r\n                ");
            EndContext();
            BeginContext(1617, 45, false);
#line 55 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 433, true);
            WriteLiteral(@"
            </th>
            <th class=""center-parent"" width=5%>
                Edit
            </th>
            <th class=""center-parent"" width=5%>
                Progress
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
#line 73 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2144, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2207, 37, false);
#line 78 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2334, 45, false);
#line 81 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(2379, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 83 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2476, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2535, 43, false);
#line 86 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 89 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2685, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(2761, 43, false);
#line 93 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2804, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 95 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2879, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 101 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(3189, 223, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n                            ");
            EndContext();
            BeginContext(3413, 140, false);
#line 105 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-star-o", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(3553, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 108 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3660, 80, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(3741, 138, false);
#line 112 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-star", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(3879, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 114 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3954, 64, true);
            WriteLiteral("                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4019, 95, false);
#line 117 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "UpdateTodo", "Todo", new { id = item.ID }, new { @class = "fas fa-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(4114, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4182, 43, false);
#line 120 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(4225, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4248, 147, false);
#line 121 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "ProgressEdit", "Todo", new { id = item.ID }, new { @class = "fa fa-flag-checkered", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(4395, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4485, 145, false);
#line 124 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "FinishTodo", "Todo", new { id = item.ID }, new { @class = "fa fa-flag-checkered", onclick = "return confirm('Finish Todo" }));

#line default
#line hidden
            EndContext();
            BeginContext(4630, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4720, 163, false);
#line 127 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
               Write(Html.ActionLink("", "DeleteTodo", "Todo", new { id = item.ID }, new { @class = "fas fa-trash-alt", onclick = "return confirm('Bạn có muốn xóa To-to List này?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(4883, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 130 "C:\Users\Admin\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\TodoListAllGroup.cshtml"
        }

#line default
#line hidden
            BeginContext(4938, 76, true);
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
