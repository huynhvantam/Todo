#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b2729c2e1ae5d9d9ca1e911c0f5baf8e77301c"
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
#line 1 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web;

#line default
#line hidden
#line 2 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\_ViewImports.cshtml"
using Todo.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b2729c2e1ae5d9d9ca1e911c0f5baf8e77301c", @"/Views/Todo/ListFinishGroup.cshtml")]
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
#line 3 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
  
    ViewData["Title"] = "ListFinishGroup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 6, true);
            WriteLiteral("<h1>  ");
            EndContext();
            BeginContext(157, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b2729c2e1ae5d9d9ca1e911c0f5baf8e77301c5288", async() => {
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
            WriteLiteral(" Todo Finish </h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(284, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b2729c2e1ae5d9d9ca1e911c0f5baf8e77301c6863", async() => {
                BeginContext(365, 11, true);
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
            BeginContext(380, 488, true);
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
            BeginContext(869, 38, false);
#line 45 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(907, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=10% class=\"center-parent\">\r\n                ");
            EndContext();
            BeginContext(995, 46, false);
#line 48 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=80%>\r\n                ");
            EndContext();
            BeginContext(1109, 44, false);
#line 52 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 161, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"center-parent\" width=5%>\r\n                Delete\r\n            </th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 63 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1363, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1424, 37, false);
#line 67 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(1551, 45, false);
#line 70 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 72 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(1693, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(1752, 43, false);
#line 75 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 78 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1902, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(1978, 43, false);
#line 82 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 84 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2096, 66, true);
            WriteLiteral("\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2163, 126, false);
#line 88 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
               Write(Html.ActionLink("", "DeleteTodoFinsih", "Todo", new { id = item.ID }, new { @id = "colorblack", @class = "fas fa-trash-alt" }));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 92 "C:\Users\tamhv\Desktop\project\Todo\Todo\todo\Todo.Web\Todo.Web\Views\Todo\ListFinishGroup.cshtml"
        }

#line default
#line hidden
            BeginContext(2346, 24, true);
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
