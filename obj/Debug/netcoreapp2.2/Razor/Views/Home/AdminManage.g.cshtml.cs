#pragma checksum "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ed3ac91be297c53d3a7c54a8f3b3ab31dbdb56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminManage), @"mvc.1.0.view", @"/Views/Home/AdminManage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AdminManage.cshtml", typeof(AspNetCore.Views_Home_AdminManage))]
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
#line 1 "/Users/rachealmayer/Desktop/C#/project/project/Views/_ViewImports.cshtml"
using project;

#line default
#line hidden
#line 2 "/Users/rachealmayer/Desktop/C#/project/project/Views/_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ed3ac91be297c53d3a7c54a8f3b3ab31dbdb56", @"/Views/Home/AdminManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/AdminManage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 139, true);
            WriteLiteral("    <link href=\"https://fonts.googleapis.com/css2?family=Merriweather&family=Playfair+Display:wght@500&display=swap\" rel=\"stylesheet\">\n    ");
            EndContext();
            BeginContext(157, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6ed3ac91be297c53d3a7c54a8f3b3ab31dbdb564004", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 1443, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
                <a class=""navbar-brand"">Admin Dashboard</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" href=""/logout"">Logout</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" href=""/home"">Home</a>
                        </li>
                    </ul>
                </div>
            </div>
");
            WriteLiteral(@"        </nav>
    <div class=""container"">
<h1>Admin Manage Users</h1>
<a class=""btn btn-sm"" style=""margin-left:90%;"" href=""/create"">Add New</a>

<table class=""table border border-danger"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Created At</th>
            <th>User Level</th>
            <th>Actions</th>
        </tr>
    </thead>
<tbody>
");
            EndContext();
#line 38 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
     foreach(var u in Model)
    {

#line default
#line hidden
            BeginContext(1688, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(1710, 8, false);
#line 41 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
       Write(u.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(1718, 21, true);
            WriteLiteral("</td>\n        <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1739, "\"", 1761, 2);
            WriteAttributeValue("", 1746, "/show/", 1746, 6, true);
#line 42 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
WriteAttributeValue("", 1752, u.UserId, 1752, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1762, 20, true);
            WriteLiteral(" class=\"btn btn-sm\">");
            EndContext();
            BeginContext(1783, 11, false);
#line 42 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
                                                     Write(u.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1794, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1796, 10, false);
#line 42 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
                                                                  Write(u.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1806, 26, true);
            WriteLiteral("</a></td>\n            <td>");
            EndContext();
            BeginContext(1833, 7, false);
#line 43 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
           Write(u.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1840, 23, true);
            WriteLiteral(" </td>\n            <td>");
            EndContext();
            BeginContext(1864, 11, false);
#line 44 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
           Write(u.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1875, 23, true);
            WriteLiteral("</td>\n            <td> ");
            EndContext();
#line 45 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
                  if(@u.Admin)
                { 

#line default
#line hidden
            BeginContext(1931, 39, true);
            WriteLiteral("                    <span>Admin</span>\n");
            EndContext();
#line 48 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
                } 
                else
                {

#line default
#line hidden
            BeginContext(2028, 38, true);
            WriteLiteral("                    <span>User</span> ");
            EndContext();
#line 51 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
                                      }

#line default
#line hidden
            BeginContext(2067, 25, true);
            WriteLiteral(" </td>\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2092, "\"", 2120, 2);
            WriteAttributeValue("", 2099, "/Admin/edit/", 2099, 12, true);
#line 52 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
WriteAttributeValue("", 2111, u.UserId, 2111, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2121, 24, true);
            WriteLiteral(">Edit</a>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2145, "\"", 2169, 2);
            WriteAttributeValue("", 2152, "/delete/", 2152, 8, true);
#line 53 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
WriteAttributeValue("", 2160, u.UserId, 2160, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2170, 28, true);
            WriteLiteral(">Remove</a> </td>\n    </tr>\n");
            EndContext();
#line 55 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/AdminManage.cshtml"
    }

#line default
#line hidden
            BeginContext(2204, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591