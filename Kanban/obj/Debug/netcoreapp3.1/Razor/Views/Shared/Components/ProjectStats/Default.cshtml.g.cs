#pragma checksum "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4105c0f63ed3fa087f74a3ce2f42648be6119e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectStats_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectStats/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\_ViewImports.cshtml"
using Kanban;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml"
using Kanban.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4105c0f63ed3fa087f74a3ce2f42648be6119e8", @"/Views/Shared/Components/ProjectStats/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d059c033f131b40ea5882f2865525b2402d58f05", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectStats_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<IssueState, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>Aktualny status zadań:</div>\r\n<ul>\r\n");
#nullable restore
#line 8 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml"
     foreach (var keyValue in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml"
       Write(Html.DisplayFor(m => keyValue.Key));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml"
                                             Write(keyValue.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 11 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\Components\ProjectStats\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<IssueState, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591