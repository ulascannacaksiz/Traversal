#pragma checksum "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7933d5016a30981877ff0a3935dd000c5fb18148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7933d5016a30981877ff0a3935dd000c5fb18148", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8498e28da0f47f33f43caf4ed1e91cb1fea8198", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TraversalCoreProje.Areas.Admin.Models.GuideViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int c = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<h1>Rehber Listesi </h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Resim</th>\r\n        <th>Ad soyad</th>\r\n        <th>Açıklama</th>\r\n        <th>Durum</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {
        c++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
           Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 556, "\"", 573, 1);
#nullable restore
#line 28 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 562, item.Image, 562, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded\" width=\"50\" height=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 714, "\"", 764, 2);
            WriteAttributeValue("", 721, "/Admin/Guide/ChangeStatus/", 721, 26, true);
#nullable restore
#line 31 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 747, item.EncryptedId, 747, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\'", 765, "\'", 843, 4);
            WriteAttributeValue("", 773, "badge", 773, 5, true);
            WriteAttributeValue(" ", 778, "bg-label-", 779, 10, true);
#nullable restore
#line 31 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 788, item.Status == true ? "danger" : "info", 788, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 830, "rounded-pill", 831, 13, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                                                                                                                                                 Write(item.Status == true ? "pasif yap" : "aktif yap");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 924, "\"", 971, 2);
            WriteAttributeValue("", 931, "/Admin/Guide/EditGuide/", 931, 23, true);
#nullable restore
#line 32 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 954, item.EncryptedId, 954, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Guide/AddGuide\" class=\"btn btn-primary\">Yeni Rehber Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TraversalCoreProje.Areas.Admin.Models.GuideViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
