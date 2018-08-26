#pragma checksum "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207c578a37a93ef5e94fd50d8846f9e295c4411f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateComment), @"mvc.1.0.view", @"/Views/Home/CreateComment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CreateComment.cshtml", typeof(AspNetCore.Views_Home_CreateComment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207c578a37a93ef5e94fd50d8846f9e295c4411f", @"/Views/Home/CreateComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bb5baaefccb3f53ae38946224ebf0e73054d31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<News, NewsAggregator.Data.ApplicationDbContext>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 59, true);
            WriteLiteral("\r\n<div style=\"font-size: 150%\">Комментарии:</div>\r\n<hr />\r\n");
            EndContext();
#line 6 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
 if (Model.Item2 != null)
{

#line default
#line hidden
            BeginContext(197, 37, true);
            WriteLiteral("    <div class=\"table\" id=\"table1\">\r\n");
            EndContext();
#line 9 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
         foreach (var comment in Model.Item2.Comments)
        {
            if (comment.NewsId == Model.Item1.Id)
            {
                string path;
                try
                {
                    path = Model.Item2.AppUsers.First(u => u.UserName == comment.UserName).ImageHref;
                }
                catch
                {
                    path = "/images/UsersImages/DefaultUser.png";
                }


#line default
#line hidden
            BeginContext(689, 142, true);
            WriteLiteral("                <div style=\"clear:both\">\r\n                    <div class=\"commentImageDiv\">\r\n                        <img class=\"commentImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 831, "\"", 856, 1);
#line 25 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
WriteAttributeValue(" ", 837, Url.Content(path), 838, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(857, 78, true);
            WriteLiteral(">\r\n\r\n                    </div>\r\n                    <div class=\"commentHead\">");
            EndContext();
            BeginContext(936, 16, false);
#line 28 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
                                        Write(comment.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("</div>\r\n                    <div class=\"commentFooter\">");
            EndContext();
            BeginContext(1008, 12, false);
#line 29 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
                                          Write(comment.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 73, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"commentBody\">");
            EndContext();
            BeginContext(1094, 12, false);
#line 31 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
                                    Write(comment.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 32, true);
            WriteLiteral("</div>\r\n                <hr />\r\n");
            EndContext();
#line 33 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1164, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 36 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
}

#line default
#line hidden
#line 37 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
 if (User.Identity.Name != null)
{

#line default
#line hidden
            BeginContext(1216, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1220, 588, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5e382fb8b904fdcb2be30150ec8864a", async() => {
                BeginContext(1288, 145, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <textarea class=\"form-control\" name=\"text\" id=\"text\"></textarea>\r\n        </div>\r\n        <div>\r\n");
                EndContext();
                BeginContext(1705, 96, true);
                WriteLiteral("            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-newsId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
                                           WriteLiteral(Model.Item1.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["newsId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-newsId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["newsId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1808, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1822, 73, true);
            WriteLiteral("    <div>\r\n        You must be logged in to write comments.\r\n    </div>\r\n");
            EndContext();
#line 55 "D:\NURE\BaseCamp\NewsAggregator\NewsAggregator\Views\Home\CreateComment.cshtml"
}

#line default
#line hidden
            BeginContext(1898, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<News, NewsAggregator.Data.ApplicationDbContext>> Html { get; private set; }
    }
}
#pragma warning restore 1591
