#pragma checksum "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomePageHeaderComponet\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "057d7ef41d7f42a05f043616c4a02adef31633cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomePageHeaderComponet_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomePageHeaderComponet/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057d7ef41d7f42a05f043616c4a02adef31633cc", @"/Views/Shared/Components/HomePageHeaderComponet/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548d2af263a2b236b90ad53b790d00f6f7a7b303", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomePageHeaderComponet_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomePageHeaderComponet\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--topbar start-->
<div id=""header-top-bar"" class=""primary-bg py-2"">
    <div class=""container"">
        <div class=""row justify-content-between align-items-center"">
            <div class=""col-md-7 col-lg-7 d-none d-md-block d-lg-block"">
                <div class=""topbar-text text-white"">
                    <ul class=""list-inline"">
                        <li class=""list-inline-item""><span class=""fas fa-envelope mr-1""></span> <a href=""mailto:support@yourdomain.com"">");
#nullable restore
#line 13 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomePageHeaderComponet\Default.cshtml"
                                                                                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"list-inline-item\"><span class=\"fas fa-map-marker mr-1\"></span>");
#nullable restore
#line 14 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomePageHeaderComponet\Default.cshtml"
                                                                                            Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-4 col-lg-4"">
                <div class=""topbar-text text-white"">
                    <ul class=""list-inline text-md-right text-lg-right text-left"">
                        <li class=""list-inline-item""><span class=""ti-phone mr-2""></span> Call Now: <strong>");
#nullable restore
#line 21 "C:\Users\Kamil\Desktop\Test\AspProject\AspProject\Views\Shared\Components\HomePageHeaderComponet\Default.cshtml"
                                                                                                      Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--topbar end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
