#pragma checksum "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08f3ad678facd21221bbe0901067c11ac7fbf920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Blog), @"mvc.1.0.view", @"/Views/Shared/_Blog.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\_ViewImports.cshtml"
using AspProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\_ViewImports.cshtml"
using AspProject.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\_ViewImports.cshtml"
using AspProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08f3ad678facd21221bbe0901067c11ac7fbf920", @"/Views/Shared/_Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548d2af263a2b236b90ad53b790d00f6f7a7b303", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<HomeOurNewsItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top position-relative img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<!--blog section start-->\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 6 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-lg-4\">\r\n            <div class=\"single-blog-card card border-0 shadow-sm\">\r\n                <div class=\"blog-img\">\r\n                    <a href=\"#\"><span class=\"category position-absolute\">");
#nullable restore
#line 11 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
                                                                    Write(item.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                    <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "08f3ad678facd21221bbe0901067c11ac7fbf9205093", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 535, "~/uploads/", 535, 10, true);
#nullable restore
#line 12 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
AddHtmlAttributeValue("", 545, item.Photo, 545, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"h5 mb-2 card-title\"><a href=\"#\">");
#nullable restore
#line 15 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
                                    Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""card-footer border-0 d-flex align-items-center justify-content-between"">
                    <div class=""author-meta d-flex align-items-center"">
                        <span class=""fa fa-user mr-2 p-3 bg-white rounded-circle border""></span>
                        <div class=""author-content"">
                            <a href=""#"" class=""d-block"">");
#nullable restore
#line 22 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
                                                   Write(item.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <small>");
#nullable restore
#line 23 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
                              Write(item.AddedDate.ToString("MMMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                    <div class=""author-like"">
                        <a href=""#""><span class=""fa fa-share-alt""></span> 50</a>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 32 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\_Blog.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<!--blog section end-->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<HomeOurNewsItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
