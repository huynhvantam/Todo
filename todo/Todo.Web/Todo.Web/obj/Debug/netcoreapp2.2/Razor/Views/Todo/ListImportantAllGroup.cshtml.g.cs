#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2cda79ff1413ebb9d2f0706e909d5fa4175b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_ListImportantAllGroup), @"mvc.1.0.view", @"/Views/Todo/ListImportantAllGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/ListImportantAllGroup.cshtml", typeof(AspNetCore.Views_Todo_ListImportantAllGroup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2cda79ff1413ebb9d2f0706e909d5fa4175b5e", @"/Views/Todo/ListImportantAllGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_ListImportantAllGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.TodoView>>
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
#line 3 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
  
    ViewData["Title"] = "ListImportantAllGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 8, true);
            WriteLiteral("\r\n<h1>  ");
            EndContext();
            BeginContext(165, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2cda79ff1413ebb9d2f0706e909d5fa4175b5e5346", async() => {
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
            BeginContext(261, 34, true);
            WriteLiteral(" Todo Important </h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(295, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d2cda79ff1413ebb9d2f0706e909d5fa4175b5e6924", async() => {
                BeginContext(376, 11, true);
                WriteLiteral("Create Todo");
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
            BeginContext(391, 486, true);
            WriteLiteral(@"

</p>

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
            BeginContext(878, 38, false);
#line 45 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(916, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=10% class=\"center-parent\">\r\n                ");
            EndContext();
            BeginContext(1004, 46, false);
#line 48 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=80%>\r\n                ");
            EndContext();
            BeginContext(1118, 44, false);
#line 52 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 154, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=12%>\r\n                Add\r\n            </th>\r\n            <th class=\"center-parent\" width=5%>\r\n                ");
            EndContext();
            BeginContext(1317, 45, false);
#line 58 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 435, true);
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
#line 77 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1846, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1909, 37, false);
#line 82 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2036, 45, false);
#line 85 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 87 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2178, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2237, 43, false);
#line 90 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2280, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 93 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2387, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(2463, 43, false);
#line 97 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 99 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2581, 44, true);
            WriteLiteral("\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2626, 128, false);
#line 103 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
               Write(Html.ActionLink("", "Index", "ListTodo", new { id = item.ID }, new { @id = "colorcornflowerblue", @class = "fas fa-book-open" }));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 23, true);
            WriteLiteral("\r\n                    (");
            EndContext();
            BeginContext(2778, 48, false);
#line 104 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                Write(Html.DisplayFor(modelItem => item.AllListFinish));

#line default
#line hidden
            EndContext();
            BeginContext(2826, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2828, 42, false);
#line 104 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.AllList));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 28, true);
            WriteLiteral(")\r\n                </td>\r\n\r\n");
            EndContext();
#line 107 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2970, 223, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n                            ");
            EndContext();
            BeginContext(3194, 108, false);
#line 111 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodoImportant", "Todo", new { id = item.ID }, new { @class = "fa fa-star-o" }));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 114 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3409, 80, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(3490, 106, false);
#line 118 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                       Write(Html.ActionLink("", "ImportantTodoImportant", "Todo", new { id = item.ID }, new { @class = "fa fa-star" }));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 120 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3671, 64, true);
            WriteLiteral("                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(3736, 115, false);
#line 123 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
               Write(Html.ActionLink("", "UpdateTodo", "Todo", new { id = item.ID }, new { @id = "colorgreen", @class = "fas fa-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(3851, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(3941, 182, false);
#line 126 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
               Write(Html.ActionLink("", "FinishTodo", "Todo", new { id = item.ID }, new { @id = "colorred", @class = "fa fa-flag-checkered", onclick = "return confirm('Are you sure to finish todo?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(4123, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4213, 180, false);
#line 129 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
               Write(Html.ActionLink("", "DeleteTodo", "Todo", new { id = item.ID }, new { @id = "colorblack", @class = "fas fa-trash-alt", onclick = "return confirm('Are you sure to delete todo?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(4393, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 132 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListImportantAllGroup.cshtml"
        }

#line default
#line hidden
            BeginContext(4448, 24, true);
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
