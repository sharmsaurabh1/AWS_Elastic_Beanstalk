#pragma checksum "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c763f5acc74f01fbb3c76c1f111efc690b3a0601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Details), @"mvc.1.0.view", @"/Views/Videos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Videos/Details.cshtml", typeof(AspNetCore.Views_Videos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c763f5acc74f01fbb3c76c1f111efc690b3a0601", @"/Views/Videos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7105a855e11af1dacb3944724c12f3f6445667", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AWS_ElasticBeanstalk_Project.Models.Video>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var userId = ViewData["userId"].ToString();

#line default
#line hidden
            BeginContext(146, 35, true);
            WriteLiteral("\r\n<h2>Video Details</h2>\r\n\r\n<div>\r\n");
            EndContext();
#line 12 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
     if (!string.IsNullOrEmpty(userId))
    {

#line default
#line hidden
            BeginContext(229, 18, true);
            WriteLiteral("        <h4>User: ");
            EndContext();
            BeginContext(248, 6, false);
#line 14 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
             Write(userId);

#line default
#line hidden
            EndContext();
            BeginContext(254, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 15 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(268, 70, true);
            WriteLiteral("    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(339, 41, false);
#line 19 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(424, 37, false);
#line 22 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(461, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(505, 40, false);
#line 25 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(589, 36, false);
#line 28 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(625, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(669, 49, false);
#line 31 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverallRating));

#line default
#line hidden
            EndContext();
            BeginContext(718, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(762, 45, false);
#line 34 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverallRating));

#line default
#line hidden
            EndContext();
            BeginContext(807, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(851, 42, false);
#line 37 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commnt));

#line default
#line hidden
            EndContext();
            BeginContext(893, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(937, 38, false);
#line 40 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commnt));

#line default
#line hidden
            EndContext();
            BeginContext(975, 49, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1024, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2cb2cd6ebe4760a1d5628db90a7471", async() => {
                BeginContext(1075, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
                           WriteLiteral(Model.VideoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1083, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1092, 76, false);
#line 47 "C:\Users\saura\Documents\Important Folders\Semester-03_Files\API Engineering & Cloud Computing\Assignments\AWS_ElasticBeanstalk_Project\Views\Videos\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index", "Videos", new { userId = @userId }));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1218, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AWS_ElasticBeanstalk_Project.Models.Video> Html { get; private set; }
    }
}
#pragma warning restore 1591
