#pragma checksum "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f9fa6fc42c934d438aa72d553c44447b6286a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display), @"mvc.1.0.view", @"/Views/Home/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Display.cshtml", typeof(AspNetCore.Views_Home_Display))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f9fa6fc42c934d438aa72d553c44447b6286a5", @"/Views/Home/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Display.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9f9fa6fc42c934d438aa72d553c44447b6286a55099", async() => {
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
            BeginContext(62, 293, true);
            WriteLiteral(@"
<link href=""https://fonts.googleapis.com/css2?family=Libre+Baskerville:ital@0;1&family=Merriweather&family=Playfair+Display:wght@500&display=swap"" rel=""stylesheet"">  
<nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark border-bottom box-shadow mb-3"">
                ");
            EndContext();
            BeginContext(355, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f9fa6fc42c934d438aa72d553c44447b6286a56629", async() => {
                BeginContext(432, 18, true);
                WriteLiteral("Chicago Connection");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            BeginContext(454, 787, true);
            WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            <a class=""nav-link text-white"" href=""/logout"">Logout</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link text-white"" href=""/home"">Home</a>
                        </li>
");
            EndContext();
#line 18 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                         if(Model.Admin == true) 
                {

#line default
#line hidden
            BeginContext(1309, 154, true);
            WriteLiteral("                    <li class=\"nav-item\">\n                    <a href=\"/Admin/Manage\" class=\"nav-link text-dark\">Admin Page</a>\n                    </li>\n");
            EndContext();
#line 23 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                }

#line default
#line hidden
            BeginContext(1481, 142, true);
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n        </nav>\n<div class=\"hangs\">\n<h1 style=\"font-size: 35px;\">Hang outs ");
            EndContext();
            BeginContext(1624, 15, false);
#line 29 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                                  Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1639, 70, true);
            WriteLiteral(" has planned:</h1>\n    <table class=\"table table-sm\">\n        <tbody>\n");
            EndContext();
#line 32 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
         foreach( var Meetup in Model.PlannedActivities)
        {

#line default
#line hidden
            BeginContext(1776, 39, true);
            WriteLiteral("            <tr>\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1815, "\"", 1848, 2);
            WriteAttributeValue("", 1822, "/activity/", 1822, 10, true);
#line 35 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
WriteAttributeValue("", 1832, Meetup.MeetUpId, 1832, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1849, 62, true);
            WriteLiteral("><img style=\"border-radius: 10px;height: 100px; width: 150px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1911, "\"", 1931, 1);
#line 35 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
WriteAttributeValue("", 1917, Meetup.ActImg, 1917, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1932, 62, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\"></a></td>\n                <td>");
            EndContext();
            BeginContext(1995, 12, false);
#line 36 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
               Write(Meetup.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2007, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(2034, 31, false);
#line 37 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
               Write(Meetup.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2065, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2067, 31, false);
#line 37 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                                                Write(Meetup.Date.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(2098, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 39 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
        }

#line default
#line hidden
            BeginContext(2132, 91, true);
            WriteLiteral("        </tbody>\n    </table>\n<h1>& RSVPs:</h1>\n<table class=\"table table-sm\">\n    <tbody>\n");
            EndContext();
#line 45 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
         foreach( var A in Model.MyJoins)
{

#line default
#line hidden
            BeginContext(2267, 31, true);
            WriteLiteral("        <tr>\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2298, "\"", 2326, 2);
            WriteAttributeValue("", 2305, "/activity/", 2305, 10, true);
#line 48 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
WriteAttributeValue("", 2315, A.MeetUpId, 2315, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2327, 63, true);
            WriteLiteral("><img style=\"border-radius: 10px; height: 100px; width: 150px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2390, "\"", 2412, 1);
#line 48 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
WriteAttributeValue("", 2396, A.Joined.ActImg, 2396, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2413, 58, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\"></a></td>\n            <td>");
            EndContext();
            BeginContext(2472, 14, false);
#line 49 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
           Write(A.Joined.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2486, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(2509, 33, false);
#line 50 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
           Write(A.Joined.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2542, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2544, 33, false);
#line 50 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                                              Write(A.Joined.Date.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(2577, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 52 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
}

#line default
#line hidden
            BeginContext(2599, 114, true);
            WriteLiteral("    </tbody>\n</table>\n</div>\n<div class=\"card\" style=\"width: 700px; margin-left:60px; margin-top: 20px;\">\n    <h1>");
            EndContext();
            BeginContext(2714, 15, false);
#line 57 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2731, 14, false);
#line 57 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2745, 14, true);
            WriteLiteral("</h1>\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2759, "\"", 2778, 1);
#line 58 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
WriteAttributeValue("", 2765, Model.ImgUrl, 2765, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2779, 293, true);
            WriteLiteral(@" style= ""height: 300px; width: 399px; border-radius: 10px;"" alt=""image of User"">
    <div class=""card-body"">
    <p class=""card-text"">
        <ul>
        <img style=""width: 50px; height: 50px;"" src=""https://www.expectmorearizona.org/wp-content/uploads/2019/01/Email-Icon.png"" alt=""""> Email: ");
            EndContext();
            BeginContext(3073, 11, false);
#line 62 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                                                                                                                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3084, 181, true);
            WriteLiteral(" <br>\n        <img style=\"width: 50px; height: 50px;\" src=\"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRHhBYHepcwInj2aKqjHlhngICkuBjSv50CrQ&usqp=CAU\" alt=\"\"> Instagram: ");
            EndContext();
            BeginContext(3266, 12, false);
#line 63 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                                                                                                                                                                          Write(Model.Handle);

#line default
#line hidden
            EndContext();
            BeginContext(3278, 27, true);
            WriteLiteral("\n            <li>Industry: ");
            EndContext();
            BeginContext(3306, 14, false);
#line 64 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                     Write(Model.Industry);

#line default
#line hidden
            EndContext();
            BeginContext(3320, 36, true);
            WriteLiteral("</li>\n            <li>Member Since: ");
            EndContext();
            BeginContext(3357, 35, false);
#line 65 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                         Write(Model.CreatedAt.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3392, 34, true);
            WriteLiteral("</li>\n            <li>User Level: ");
            EndContext();
#line 66 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                             if(@Model.Admin)
                { 

#line default
#line hidden
            BeginContext(3463, 39, true);
            WriteLiteral("                    <span>Admin</span>\n");
            EndContext();
#line 69 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                } 
                else
                {

#line default
#line hidden
            BeginContext(3560, 38, true);
            WriteLiteral("                    <span>User</span> ");
            EndContext();
#line 72 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                                      }

#line default
#line hidden
            BeginContext(3599, 37, true);
            WriteLiteral(" </li><br>\n            <li>About Me: ");
            EndContext();
            BeginContext(3637, 17, false);
#line 73 "/Users/rachealmayer/Desktop/C#/project/project/Views/Home/Display.cshtml"
                     Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3654, 36, true);
            WriteLiteral("</li>\n        </ul>\n    </p>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
