#pragma checksum "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af7ec78caa4c60646af476405a23d58b26e8975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
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
#line 1 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af7ec78caa4c60646af476405a23d58b26e8975", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"comments mt-5\">\r\n    <h4 class=\"side-title \">Yorumlar (");
#nullable restore
#line 3 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                                 Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n");
#nullable restore
#line 4 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""media mt-4"">
            <div class=""img-circle"">
                <img src=""/Traversal-Starter/assets/images/c1.jpg"" class=""img-fluid"" alt=""..."">
            </div>

            <div class=""media-body"">

                <ul class=""time-rply mb-2"">
                    <li>
                        <a href=""#URL"" class=""name mt-0 mb-2 d-block"">");
#nullable restore
#line 15 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                                                                 Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 16 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                   Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </li>
                    <li class=""reply-last"">
                        <a href=""#reply"" class=""reply"">
                            Reply
                        </a>
                    </li>
                </ul>
                <p>
                    ");
#nullable restore
#line 26 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
               Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591