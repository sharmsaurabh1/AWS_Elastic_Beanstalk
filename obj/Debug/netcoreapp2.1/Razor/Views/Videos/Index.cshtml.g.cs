#pragma checksum "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e39cf05c5866579a3246d3ab4f2e5bb5245086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Index), @"mvc.1.0.view", @"/Views/Videos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Videos/Index.cshtml", typeof(AspNetCore.Views_Videos_Index))]
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
#line 1 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\_ViewImports.cshtml"
using AWS_ElasticBeanstalk_Project;

#line default
#line hidden
#line 2 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\_ViewImports.cshtml"
using AWS_ElasticBeanstalk_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e39cf05c5866579a3246d3ab4f2e5bb5245086", @"/Views/Videos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7105a855e11af1dacb3944724c12f3f6445667", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AWS_ElasticBeanstalk_Project.Models.Video>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/laxmibomb.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ASP.NET"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avengersInfinityWar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avengers Infinity wars"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Avengers_ Endgame.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avengers EndGame"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
  
    ViewData["Title"] = "Videos";
    var userId = ViewData["userId"].ToString();

#line default
#line hidden
            BeginContext(156, 31, true);
            WriteLiteral("\r\n\r\n<h2>List of Videos</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
 if (!string.IsNullOrEmpty(userId))
{

#line default
#line hidden
            BeginContext(227, 14, true);
            WriteLiteral("    <h4>User: ");
            EndContext();
            BeginContext(242, 6, false);
#line 13 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
         Write(userId);

#line default
#line hidden
            EndContext();
            BeginContext(248, 16, true);
            WriteLiteral("</h4>\r\n    <p>\r\n");
            EndContext();
            BeginContext(315, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(324, 74, false);
#line 16 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
   Write(Html.ActionLink("Create New", "Create", "Videos", new {userId = @userId }));

#line default
#line hidden
            EndContext();
            BeginContext(398, 14, true);
            WriteLiteral(" |\r\n    </p>\r\n");
            EndContext();
#line 18 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(415, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(504, 41, false);
#line 25 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(545, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(601, 40, false);
#line 28 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(641, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(697, 49, false);
#line 31 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OverallRating));

#line default
#line hidden
            EndContext();
            BeginContext(746, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(802, 42, false);
#line 34 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Commnt));

#line default
#line hidden
            EndContext();
            BeginContext(844, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(979, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1028, 40, false);
#line 44 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1124, 39, false);
#line 47 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1219, 48, false);
#line 50 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OverallRating));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1323, 41, false);
#line 53 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Commnt));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 25, true);
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n");
            EndContext();
#line 57 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
             if (!string.IsNullOrEmpty(userId) && userId != "0")
            {

#line default
#line hidden
            BeginContext(1470, 22, true);
            WriteLiteral("                <td>\r\n");
            EndContext();
            BeginContext(1744, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1765, 87, false);
#line 63 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "Videos", new { id = @item.VideoId, userId = @userId }));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1877, 93, false);
#line 64 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", "Videos", new { id = @item.VideoId, userId = @userId }));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(2224, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
#line 68 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2262, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2288, 491, true);
            WriteLiteral(@"    </tbody>


    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <div class=""item active"">
                ");
            EndContext();
            BeginContext(2779, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0769cd9f442e4d28ae1cf19f03431dd9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2852, 482, true);
            WriteLiteral(@"
                <div class=""carousel-caption"" role=""option"">
                    <p>
                        Laxmii- Official Trailer
                        <a class=""btn btn-default"" href=""https://www.youtube.com/watch?v=xw0gE8QA1W0"" style=""color:hotpink"">
                            >
                            Click Me
                        </a>
                    </p>
                </div>
            </div>
            <div class=""item"">
                ");
            EndContext();
            BeginContext(3334, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e66304a9d54b4607b53ec16f51025ac0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3432, 484, true);
            WriteLiteral(@"
                <div class=""carousel-caption"" role=""option"">
                    <p>
                        Marvel Studios' Avengers: Infinity War - Official Trailer
                        <a class=""btn btn-default"" href=""https://www.youtube.com/watch?v=QwievZ1Tx-8"" style=""color:hotpink"">
                            Click Me
                        </a>
                    </p>
                </div>
            </div>
            <div class=""item"">
                ");
            EndContext();
            BeginContext(3916, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a553c3afac9240889736d1f527d882dc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4006, 994, true);
            WriteLiteral(@"
                <div class=""carousel-caption"" role=""option"">
                    <p>
                        Marvel Studios' Avengers: Endgame - Official Trailer
                        <a class=""btn btn-default"" href=""https://www.youtube.com/watch?v=TcMBFSGVi1c"" style=""color:hotpink"">
                            Click Me
                        </a>
                    </p>
                </div>
            </div>
        </div>
        <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
    <table>
        <tr>
            <td>
");
            EndContext();
#line 128 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
                 if (string.IsNullOrEmpty(userId))
                {

#line default
#line hidden
            BeginContext(5071, 153, true);
            WriteLiteral("                    <div>\r\n                        <span>&nbsp;</span>\r\n                    </div>\r\n                    <p>\r\n                        <b> ");
            EndContext();
            BeginContext(5225, 53, false);
#line 134 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
                       Write(Html.ActionLink("Go_Back_To_LogIn", "Login", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(5278, 32, true);
            WriteLiteral("</b>\r\n                    </p>\r\n");
            EndContext();
#line 136 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5329, 58, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n    </table>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AWS_ElasticBeanstalk_Project.Models.Video>> Html { get; private set; }
    }
}
#pragma warning restore 1591
