#pragma checksum "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4346d592d2e7010f8bae1b128ae5058137fd764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4346d592d2e7010f8bae1b128ae5058137fd764", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\"\r\n      class=\"light-style layout-menu-fixed\"\r\n      dir=\"ltr\"\r\n      data-theme=\"theme-default\"\r\n      data-assets-path=\"~/sneat-1.0.0/assets/\"\r\n      data-template=\"vertical-menu-template-free\">\r\n");
#nullable restore
#line 12 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("~/Views/Admin/PartialHeader.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4346d592d2e7010f8bae1b128ae5058137fd7644102", async() => {
                WriteLiteral("\r\n \r\n        <script>\r\n            toastr[\"");
#nullable restore
#line 17 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
               Write(TempData["Type"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"](\"");
#nullable restore
#line 17 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
                                    Write(TempData["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 17 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
                                                                Write(TempData["Subject"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n        </script>\r\n   \r\n\r\n    <div class=\"layout-wrapper layout-content-navbar\">\r\n        <div class=\"layout-container\">\r\n            <aside id=\"layout-menu\" class=\"layout-menu menu-vertical menu bg-menu-theme\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Admin/PartialAppBrandDemo.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"menu-inner-shadow\"></div>\r\n                ");
#nullable restore
#line 26 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Admin/PartialSidebar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </aside>\r\n            <div class=\"layout-page\">\r\n                ");
#nullable restore
#line 29 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Admin/PartialNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"content-wrapper\">\r\n                    <div class=\"container-xxl flex-grow-1 container-p-y\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("~/Views/Admin/PartialFooter.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"content-backdrop fade\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"layout-overlay layout-menu-toggle\"></div>\r\n    </div>\r\n    ");
#nullable restore
#line 41 "C:\Users\Ulas\source\repos\Traversal\TraversalCoreProje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("~/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
