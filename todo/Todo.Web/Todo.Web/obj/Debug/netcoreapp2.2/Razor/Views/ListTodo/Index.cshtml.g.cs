#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0608db5af91cd01f55b81655be7301e6a3995d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListTodo_Index), @"mvc.1.0.view", @"/Views/ListTodo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListTodo/Index.cshtml", typeof(AspNetCore.Views_ListTodo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0608db5af91cd01f55b81655be7301e6a3995d", @"/Views/ListTodo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_ListTodo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.ListTodo.ListTodoView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ListTodo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateListTodo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 430, true);
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

    #linethrough {
        text-decoration: line-through;
    }
</style>


<h1>  ");
            EndContext();
            BeginContext(580, 117, false);
#line 39 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
 Write(Html.ActionLink("", "Index", "Todo", new { id = ViewBag.GroupList }, new { @class = "fas fa-arrow-alt-circle-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(697, 7, true);
            WriteLiteral(" Todo: ");
            EndContext();
            BeginContext(705, 16, false);
#line 39 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                                                                                                                              Write(ViewBag.TodoList);

#line default
#line hidden
            EndContext();
            BeginContext(721, 19, true);
            WriteLiteral(" </h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(740, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e0608db5af91cd01f55b81655be7301e6a3995d5887", async() => {
                BeginContext(829, 11, true);
                WriteLiteral("Create List");
                EndContext();
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
            BeginContext(844, 167, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<table class=\"table\" width=100%>\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th width=\"5%\">\r\n                ");
            EndContext();
            BeginContext(1012, 39, false);
#line 65 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDL));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=\"80%\">\r\n                ");
            EndContext();
            BeginContext(1119, 44, false);
#line 68 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ListName));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 66, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=\"5%\">\r\n                ");
            EndContext();
            BeginContext(1230, 42, false);
#line 71 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Finish));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 228, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=\"5%\">\r\n                Edit\r\n            </th>\r\n            <th width=\"5%\">\r\n                Delete\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 83 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1549, 22, true);
            WriteLiteral("            <tr>\r\n\r\n\r\n");
            EndContext();
#line 88 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                   if (item.Finish == false)
                    {

#line default
#line hidden
            BeginContext(1640, 80, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(1721, 38, false);
#line 91 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.STT));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1851, 43, false);
#line 94 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListName));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 256, true);
            WriteLiteral(@"
                        </td>
                        <td class=""center-parent"">
                            <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
                            ");
            EndContext();
            BeginContext(2151, 133, false);
#line 98 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                       Write(Html.ActionLink("", "FinishListTodo", "ListTodo", new { id = item.IDL }, new { @id = "colorblack", @class = "fa fa-flag-checkered" }));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 100 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2391, 97, true);
            WriteLiteral("                        <td id=\"linethrough\" class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(2489, 38, false);
#line 105 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.STT));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 108, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td id=\"linethrough\">\r\n                            ");
            EndContext();
            BeginContext(2636, 43, false);
#line 108 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ListName));

#line default
#line hidden
            EndContext();
            BeginContext(2679, 113, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(2793, 131, false);
#line 111 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                       Write(Html.ActionLink("", "FinishListTodo", "ListTodo", new { id = item.IDL }, new { @id = "colorred", @class = "fa fa-flag-checkered" }));

#line default
#line hidden
            EndContext();
            BeginContext(2924, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 113 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2999, 64, true);
            WriteLiteral("                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(3064, 124, false);
#line 116 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
               Write(Html.ActionLink("", "UpdateListTodo", "ListTodo", new { id = item.IDL }, new { @id = "colorgreen", @class = "fas fa-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(3188, 91, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(3280, 189, false);
#line 120 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
               Write(Html.ActionLink("", "DeleteListTodo", "ListTodo", new { id = item.IDL }, new { @id = "colorblack", @class = "fas fa-trash-alt", onclick = "return confirm('Are you sure to delete list?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(3469, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 124 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\ListTodo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3526, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Todo.Web.Models.ListTodo.ListTodoView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
