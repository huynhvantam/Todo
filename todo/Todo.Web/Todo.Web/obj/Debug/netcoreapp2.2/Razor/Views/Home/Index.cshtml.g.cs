#pragma checksum "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98c537be0454502181f9b1459d542708ebf45b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98c537be0454502181f9b1459d542708ebf45b4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310d18f7a16cbea8b22ea33a0f8fb64b6d436e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(93, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(98, 15, false);
#line 6 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(113, 136, true);
            WriteLiteral("</h2>\r\n\r\n<p><b>Teacher List</b></p>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Code</th>\r\n        <th>Name</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
     foreach (var teacher in Model.Teachers)
    {

#line default
#line hidden
            BeginContext(302, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(333, 17, false);
#line 19 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(teacher.TeacherId);

#line default
#line hidden
            EndContext();
            BeginContext(350, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(374, 12, false);
#line 20 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(teacher.Code);

#line default
#line hidden
            EndContext();
            BeginContext(386, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(410, 12, false);
#line 21 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(422, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(453, 171, true);
            WriteLiteral("</table>\r\n\r\n<p><b>Student List</b></p>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Code</th>\r\n        <th>Name</th>\r\n        <th>Enrollment No</th>\r\n    </tr>\r\n");
            EndContext();
#line 36 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
     foreach (var student in Model.Students)
    {

#line default
#line hidden
            BeginContext(677, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(708, 17, false);
#line 39 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(student.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(725, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(749, 12, false);
#line 40 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(student.Code);

#line default
#line hidden
            EndContext();
            BeginContext(761, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(785, 12, false);
#line 41 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(797, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(821, 20, false);
#line 42 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"
           Write(student.EnrollmentNo);

#line default
#line hidden
            EndContext();
            BeginContext(841, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\tamhv\Desktop\project\Todo\todo\Todo.Web\Todo.Web\Views\Home\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(872, 10, true);
            WriteLiteral("</table>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591