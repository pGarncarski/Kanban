#pragma checksum "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\DisplayTemplates\IssueState.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db0bdf1b6ac9e4b9120e6d93381d3fe6d1be43e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_IssueState), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/IssueState.cshtml")]
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
#line 1 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\_ViewImports.cshtml"
using Kanban;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\_ViewImports.cshtml"
using Kanban.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\DisplayTemplates\IssueState.cshtml"
using Kanban.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db0bdf1b6ac9e4b9120e6d93381d3fe6d1be43e", @"/Views/Shared/DisplayTemplates/IssueState.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d059c033f131b40ea5882f2865525b2402d58f05", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_IssueState : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kanban.Models.IssueState?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\IT\Programowanie\.NET\Kursy i szkolenia\Szkolenie ASP NET Core\Projekt\Kanban\Kanban\Views\Shared\DisplayTemplates\IssueState.cshtml"
Write(ViewData.ModelMetadata.IsNullableValueType && (Model == null)  ? "brak" :  Consts.IssueStates[(IssueState)Model]);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kanban.Models.IssueState?> Html { get; private set; }
    }
}
#pragma warning restore 1591
