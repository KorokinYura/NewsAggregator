#pragma checksum "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47802619f96171020477a6a437214af56ae9a70b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47802619f96171020477a6a437214af56ae9a70b", @"/Views/Home/News.cshtml")]
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
            BeginContext(55, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
  
    ViewData["Title"] = "News";

#line default
#line hidden
            BeginContext(99, 42, true);
            WriteLiteral("\r\n<br><br><div class=\"newsFullHead\">\r\n    ");
            EndContext();
            BeginContext(142, 15, false);
#line 9 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
Write(Model.News.Name);

#line default
#line hidden
            EndContext();
            BeginContext(157, 42, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <hr />\r\n    <div>\r\n");
            EndContext();
#line 15 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
         if (User.Identity.Name == Model.News.UserName || User.IsInRole("Admin"))
        {

#line default
#line hidden
            BeginContext(293, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(305, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3826d971bb44e778e98b1c817503425", async() => {
                BeginContext(382, 123, true);
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
#line 17 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
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
            BeginContext(509, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
        }

#line default
#line hidden
            BeginContext(522, 53, true);
            WriteLiteral("        <div>\r\n            <img class=\"newsFullImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 575, "\"", 615, 1);
#line 22 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
WriteAttributeValue("", 581, Url.Content(Model.News.ImageHref), 581, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(616, 115, true);
            WriteLiteral(">\r\n        </div><br /><hr />\r\n        <div class=\"newsFullText\">\r\n            <span style=\"white-space: pre-line\">");
            EndContext();
            BeginContext(732, 15, false);
#line 25 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                                           Write(Model.News.Text);

#line default
#line hidden
            EndContext();
            BeginContext(747, 68, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(815, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0abf159c6d40f29f1edfb8bb7e7155", async() => {
                BeginContext(837, 12, true);
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
            BeginContext(853, 81, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n\r\n\r\n<div style=\"font-size: 150%\">Комментарии:</div>\r\n<hr />\r\n\r\n");
            EndContext();
#line 39 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
 if (User.Identity.Name != null)
{

#line default
#line hidden
            BeginContext(971, 322, true);
            WriteLiteral(@"    <div>
        <div class=""form-group"">
            <textarea class=""form-control"" name=""text"" id=""text""></textarea>
        </div>
        <div class=""form-group"">
            <input type=""button"" onclick=""addCommentAJAX()"" value=""Create"" id=""submitButton"" class=""btn btn-default"" />
        </div>
    </div>
");
            EndContext();
#line 49 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1305, 73, true);
            WriteLiteral("    <div>\r\n        You must be logged in to write comments.\r\n    </div>\r\n");
            EndContext();
#line 55 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
}

#line default
#line hidden
            BeginContext(1381, 162, true);
            WriteLiteral("\r\n<hr />\r\n<div class=\"table\" id=\"comments\">\r\n</div>\r\n\r\n<input type=\"button\" onclick=\"loadMoreComments()\" value=\"Load more comments\" class=\"btn btn-default\" />\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1561, 213, true);
                WriteLiteral("\r\n    <script>\r\n        $(function () { loadMoreComments(); });\r\n\r\n        let curComments = 0;\r\n\r\n        function loadMoreComments() {\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \'");
                EndContext();
                BeginContext(1775, 38, false);
#line 72 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                 Write(Url.Action("LoadMoreComments", "Load"));

#line default
#line hidden
                EndContext();
                BeginContext(1813, 32, true);
                WriteLiteral("\',\r\n                data: { id: ");
                EndContext();
                BeginContext(1846, 13, false);
#line 73 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                       Write(Model.News.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1859, 458, true);
                WriteLiteral(@", curComments: curComments },

                success: function (comments) {
                    for (let i = 0; i < comments.length; i++) {
                        addComment(comments[i]);
                    }
                }
            });
        }

        function addCommentAJAX() {
            var text = $(""#text"").val();
            $(""#text"").val = '';

            $.ajax({
                type: ""POST"",
                url: '");
                EndContext();
                BeginContext(2318, 40, false);
#line 89 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                 Write(Url.Action("CreateCommentAsync", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2358, 36, true);
                WriteLiteral("\',\r\n                data: { newsId: ");
                EndContext();
                BeginContext(2395, 13, false);
#line 90 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                           Write(Model.News.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2408, 122, true);
                WriteLiteral(", text: text },\r\n\r\n                success: writeComment\r\n            });\r\n        }\r\n\r\n        function addComments() {\r\n");
                EndContext();
                BeginContext(3148, 1040, true);
                WriteLiteral(@"        }

        function writeComment(comment) {
            $(""#comments"").prepend(
                formComment(comment)
            );
        }

        function addComment(comment) {
            $(""#comments"").append(
                formComment(comment)
            );
        }

        function formComment(comment) {
            let ret = checkForRemoveButton(comment.id) +
                '<div style=""clear:both"">' +
                '<div class=""commentImageDiv"">' +
                '<img class=""commentImage"" src=""'
                + comment.imagePath +
                '""></div><div class=""commentHead"">'
                + comment.userName +
                '</div><div class=""commentFooter"">'
                + comment.date +
                '</div></div><div class=""commentBody"">'
                + comment.text +
                '</div><hr />';
            curComments++;

            $(""#text"").val("""");

            return ret;
        }


        function checkForRemo");
                WriteLiteral("veButton(id) {\r\n");
                EndContext();
#line 149 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin") || User.IsInRole("Moderator"))
                {
                

#line default
#line hidden
                BeginContext(4368, 217, true);
                WriteLiteral("\r\n                    var button = \'<input type=\"button\" onclick=\"removeCommentAJAX(\' + id + \')\" value=\"Delete\" id=\"RemButton\" class=\"btn btn-default\" /><br><br>\';\r\n                    return button;\r\n                ");
                EndContext();
#line 156 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                       
                }
            }

#line default
#line hidden
                BeginContext(4628, 154, true);
                WriteLiteral("            return \"\";\r\n        }\r\n\r\n        function removeCommentAJAX(id) {\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \'");
                EndContext();
                BeginContext(4783, 35, false);
#line 165 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                 Write(Url.Action("RemoveComment", "Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(4818, 51, true);
                WriteLiteral("\',\r\n                data: { commentId: id, newsId: ");
                EndContext();
                BeginContext(4870, 13, false);
#line 166 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\News.cshtml"
                                          Write(Model.News.Id);

#line default
#line hidden
                EndContext();
                BeginContext(4883, 149, true);
                WriteLiteral(" },\r\n\r\n                success: function () {\r\n                    location.reload();\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
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
