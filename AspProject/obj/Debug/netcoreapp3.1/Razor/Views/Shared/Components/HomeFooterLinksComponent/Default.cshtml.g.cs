#pragma checksum "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomeFooterLinksComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf19692c89b4b99d6c4b04b25e7bb62215e4f1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeFooterLinksComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeFooterLinksComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf19692c89b4b99d6c4b04b25e7bb62215e4f1d", @"/Views/Shared/Components/HomeFooterLinksComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548d2af263a2b236b90ad53b790d00f6f7a7b303", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeFooterLinksComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspProject.Models.Home.SocialLink>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomeFooterLinksComponent\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-md-7 col-lg-6 d-none d-md-block d-lg-block"">
                <div class=""social-nav text-right"">
                    <ul class=""list-unstyled social-list mb-0"">
                        <li class=""list-inline-item tooltip-hover"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 378, "\"", 400, 1);
#nullable restore
#line 10 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomeFooterLinksComponent\Default.cshtml"
WriteAttributeValue("", 385, Model.Facebook, 385, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded""><span class=""ti-facebook""></span></a>
                            <div class=""tooltip-item"">Facebook</div>
                        </li>
                        <li class=""list-inline-item tooltip-hover"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 657, "\"", 678, 1);
#nullable restore
#line 14 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomeFooterLinksComponent\Default.cshtml"
WriteAttributeValue("", 664, Model.Twitter, 664, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded\"><span class=\"ti-twitter\"></span></a>\r\n                            <div class=\"tooltip-item\">Twitter</div>\r\n                        </li>\r\n                        <li class=\"list-inline-item tooltip-hover\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 933, "\"", 955, 1);
#nullable restore
#line 18 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomeFooterLinksComponent\Default.cshtml"
WriteAttributeValue("", 940, Model.Linkedin, 940, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded""><span class=""ti-linkedin""></span></a>
                            <div class=""tooltip-item"">Linkedin</div>
                        </li>
                        <li class=""list-inline-item tooltip-hover"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1212, "\"", 1234, 1);
#nullable restore
#line 22 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomeFooterLinksComponent\Default.cshtml"
WriteAttributeValue("", 1219, Model.Dribbble, 1219, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded\"><span class=\"ti-dribbble\"></span></a>\r\n                            <div class=\"tooltip-item\">Dribbble</div>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n           \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspProject.Models.Home.SocialLink> Html { get; private set; }
    }
}
#pragma warning restore 1591
