#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9350c29522b31f91c195f604779cffbfefedd373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9350c29522b31f91c195f604779cffbfefedd373", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo.Web.Models.Todo.TodoView>>
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
#line 3 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 12, true);
            WriteLiteral("\r\n\r\n\r\n<h1>  ");
            EndContext();
            BeginContext(153, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9350c29522b31f91c195f604779cffbfefedd3736060", async() => {
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
            BeginContext(239, 8, true);
            WriteLiteral(" Group: ");
            EndContext();
            BeginContext(248, 17, false);
#line 10 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                                                                                               Write(ViewBag.Groupname);

#line default
#line hidden
            EndContext();
            BeginContext(265, 146, true);
            WriteLiteral(" </h1>\r\n<div class=\"row\"></div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(411, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9350c29522b31f91c195f604779cffbfefedd3738190", async() => {
                BeginContext(492, 11, true);
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
            BeginContext(507, 125, true);
            WriteLiteral("\r\n\r\n            </p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-inline\">\r\n                ");
            EndContext();
            BeginContext(632, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9350c29522b31f91c195f604779cffbfefedd3739994", async() => {
                BeginContext(692, 230, true);
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
            BeginContext(929, 750, true);
            WriteLiteral(@"
            </div>

        </div>
    </div>
</div>

<style>
    #colorfinish {
        color: dodgerblue
    }

    #coloryellow {
        color: yellow
    }

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

<table class=""table center-parent"" width=100%>
    <thead class=""thead-dark"">
        <tr>

            <th width=5%>
                STT
            </th>
            <th width=10% class=""center-parent"">
                ");
            EndContext();
            BeginContext(1680, 46, false);
#line 74 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 67, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th width=80%>\r\n                ");
            EndContext();
            BeginContext(1794, 44, false);
#line 78 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(1838, 154, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=12%>\r\n                Add\r\n            </th>\r\n            <th class=\"center-parent\" width=5%>\r\n                ");
            EndContext();
            BeginContext(1993, 45, false);
#line 84 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(2038, 435, true);
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
#line 103 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2522, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2585, 38, false);
#line 108 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.STT));

#line default
#line hidden
            EndContext();
            BeginContext(2623, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(2713, 45, false);
#line 111 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(2758, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 113 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(2855, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2914, 43, false);
#line 116 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 119 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3064, 75, true);
            WriteLiteral("                        <td class=\"textgach\">\r\n                            ");
            EndContext();
            BeginContext(3140, 43, false);
#line 123 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(3183, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 125 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                    }

                

#line default
#line hidden
            BeginContext(3260, 44, true);
            WriteLiteral("\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3305, 128, false);
#line 130 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("", "Index", "ListTodo", new { id = item.ID }, new { @id = "colorcornflowerblue", @class = "fas fa-book-open" }));

#line default
#line hidden
            EndContext();
            BeginContext(3433, 23, true);
            WriteLiteral("\r\n                    (");
            EndContext();
            BeginContext(3457, 48, false);
#line 131 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.AllListFinish));

#line default
#line hidden
            EndContext();
            BeginContext(3505, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(3507, 42, false);
#line 131 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.AllList));

#line default
#line hidden
            EndContext();
            BeginContext(3549, 28, true);
            WriteLiteral(")\r\n                </td>\r\n\r\n");
            EndContext();
#line 134 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                   if (item.Important == false)
                    {

#line default
#line hidden
            BeginContext(3649, 223, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n                            ");
            EndContext();
            BeginContext(3873, 104, false);
#line 138 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                       Write(Html.ActionLink("", "ImportantTodoGroup", "Todo", new { id = item.ID }, new { @class = "fa fa-star-o" }));

#line default
#line hidden
            EndContext();
            BeginContext(3977, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 141 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4084, 80, true);
            WriteLiteral("                        <td class=\"center-parent\">\r\n                            ");
            EndContext();
            BeginContext(4165, 102, false);
#line 145 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                       Write(Html.ActionLink("", "ImportantTodoGroup", "Todo", new { id = item.ID }, new { @class = "fa fa-star" }));

#line default
#line hidden
            EndContext();
            BeginContext(4267, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 147 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(4342, 64, true);
            WriteLiteral("                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4407, 115, false);
#line 150 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("", "UpdateTodo", "Todo", new { id = item.ID }, new { @id = "colorgreen", @class = "fas fa-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(4522, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4592, 43, false);
#line 154 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(4635, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4658, 132, false);
#line 155 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("", "ProgressEditGroup", "Todo", new { id = item.ID }, new { @id = "colorfinish", @class = "fa fa-flag-checkered" }));

#line default
#line hidden
            EndContext();
            BeginContext(4790, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(4880, 187, false);
#line 158 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("", "FinishTodoGroup", "Todo", new { id = item.ID }, new { @id = "colorred", @class = "fa fa-flag-checkered", onclick = "return confirm('Are you sure to finish todo?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(5067, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"center-parent\">\r\n                    ");
            EndContext();
            BeginContext(5157, 185, false);
#line 161 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
               Write(Html.ActionLink("", "DeleteTodoGroup", "Todo", new { id = item.ID }, new { @id = "colorblack", @class = "fas fa-trash-alt", onclick = "return confirm('Are you sure to delete todo?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(5342, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 166 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5442, 24, true);
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
