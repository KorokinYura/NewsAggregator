#pragma checksum "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1975d40135f8a3e2bf447f3ed22593a737fca1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/News.cshtml", typeof(AspNetCore.Views_Home_News))]
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
#line 1 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\_ViewImports.cshtml"
using NewsAggregator;

#line default
#line hidden
#line 2 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\_ViewImports.cshtml"
using NewsAggregator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1975d40135f8a3e2bf447f3ed22593a737fca1c", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bb5baaefccb3f53ae38946224ebf0e73054d31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsAggregator.Models.ViewModels.NewsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
  
    ViewData["Title"] = "News";

#line default
#line hidden
            BeginContext(97, 42, true);
            WriteLiteral("\r\n<br><br><div class=\"newsFullHead\">\r\n    ");
            EndContext();
            BeginContext(140, 15, false);
#line 8 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
Write(Model.News.Name);

#line default
#line hidden
            EndContext();
            BeginContext(155, 42, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <hr />\r\n    <div>\r\n");
            EndContext();
#line 14 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
         if (User.Identity.Name == Model.News.UserName || User.IsInRole("Admin"))
        {

#line default
#line hidden
            BeginContext(291, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(303, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d69f354dbc40099c2a26e17f16007c", async() => {
                BeginContext(380, 123, true);
                WriteLiteral("\r\n                <span class=\"btn btn-default glyphicon glyphicon-pencil\" type=\"submit\" value=\"Edit\"></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                                                             WriteLiteral(Model.News.Id);

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
            BeginContext(507, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
        }

#line default
#line hidden
            BeginContext(520, 53, true);
            WriteLiteral("        <div>\r\n            <img class=\"newsFullImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 573, "\"", 613, 1);
#line 21 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
WriteAttributeValue("", 579, Url.Content(Model.News.ImageHref), 579, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(614, 115, true);
            WriteLiteral(">\r\n        </div><br /><hr />\r\n        <div class=\"newsFullText\">\r\n            <span style=\"white-space: pre-line\">");
            EndContext();
            BeginContext(730, 15, false);
#line 24 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                                           Write(Model.News.Text);

#line default
#line hidden
            EndContext();
            BeginContext(745, 68, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(813, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0db51de410e469d93664203d1f39246", async() => {
                BeginContext(835, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(851, 81, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n\r\n\r\n<div style=\"font-size: 150%\">Комментарии:</div>\r\n<hr />\r\n\r\n");
            EndContext();
#line 38 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
 if (User.Identity.Name != null)
{

#line default
#line hidden
            BeginContext(969, 336, true);
            WriteLiteral(@"    <div>
        <div class=""form-group"">
            <textarea class=""form-control"" name=""text"" id=""text""></textarea>
        </div>
        <div class=""form-group"">
            <span type=""button"" onclick=""addCommentAJAX()"" id=""submitButton"" class=""btn btn-default glyphicon glyphicon-send""></span>
        </div>
    </div>
");
            EndContext();
#line 48 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1317, 73, true);
            WriteLiteral("    <div>\r\n        You must be logged in to write comments.\r\n    </div>\r\n");
            EndContext();
#line 54 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
}

#line default
#line hidden
            BeginContext(1393, 162, true);
            WriteLiteral("\r\n<hr />\r\n<div class=\"table\" id=\"comments\">\r\n</div>\r\n\r\n<input type=\"button\" onclick=\"loadMoreComments()\" value=\"Load more comments\" class=\"btn btn-default\" />\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1573, 29, true);
                WriteLiteral("\r\n<script>\r\n    var newsId = ");
                EndContext();
                BeginContext(1603, 13, false);
#line 64 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
            Write(Model.News.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1616, 27, true);
                WriteLiteral(";\r\n    var loadMoreComm = \'");
                EndContext();
                BeginContext(1644, 38, false);
#line 65 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                   Write(Url.Action("LoadMoreComments", "Load"));

#line default
#line hidden
                EndContext();
                BeginContext(1682, 29, true);
                WriteLiteral("\';\r\n    var createComment = \'");
                EndContext();
                BeginContext(1712, 40, false);
#line 66 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                    Write(Url.Action("CreateCommentAsync", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1752, 29, true);
                WriteLiteral("\';\r\n    var removeComment = \'");
                EndContext();
                BeginContext(1782, 35, false);
#line 67 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                    Write(Url.Action("RemoveComment", "Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(1817, 96, true);
                WriteLiteral("\';\r\n\r\n    $(function () { loadMoreComments(); });\r\n\r\n\r\n    function checkForRemoveButton(id) {\r\n");
                EndContext();
#line 73 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
         if (User.Identity.IsAuthenticated)
        {
            if (User.IsInRole("Admin") || User.IsInRole("Moderator"))
            {
            

#line default
#line hidden
                BeginContext(2073, 231, true);
                WriteLiteral("\r\n        var button = \'<span type=\"button\" onclick=\"removeCommentAJAX(\' + id + \')\" id=\"RemButton\" class=\"btn btn-default glyphicon glyphicon-trash\" style=\"color: red\"></span><br><br>\';\r\n                return button;\r\n            ");
                EndContext();
#line 80 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                   
            }
        }

#line default
#line hidden
                BeginContext(2339, 40, true);
                WriteLiteral("        return \"\";\r\n    }\r\n\r\n</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsAggregator.Models.ViewModels.NewsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
