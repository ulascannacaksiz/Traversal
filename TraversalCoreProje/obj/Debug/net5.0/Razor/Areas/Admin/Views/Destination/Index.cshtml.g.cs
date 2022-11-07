#pragma checksum "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d1803f658d9f13decd655949f5ec78aa25d3ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1803f658d9f13decd655949f5ec78aa25d3ee7", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TraversalCoreProje.Areas.Admin.Models.DestinationViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int c = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rotalar</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Şehir</th>\r\n        <th>Fiyat</th>\r\n        <th>Kapasite</th>\r\n        <th>Sitede Gör</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
     foreach(var item in Model){
        c++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            \r\n            <td>");
#nullable restore
#line 25 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 692, "\"", 750, 2);
            WriteAttributeValue("", 699, "/Destination/DestinationDetails/", 699, 32, true);
#nullable restore
#line 29 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 731, item.DestinationId, 731, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Sitede gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 812, "\"", 873, 2);
            WriteAttributeValue("", 819, "/Admin/Destination/DeleteDestination/", 819, 37, true);
#nullable restore
#line 30 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 856, item.EncryptedId, 856, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 930, "\"", 991, 2);
            WriteAttributeValue("", 937, "/Admin/Destination/UpdateDestination/", 937, 37, true);
#nullable restore
#line 31 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 974, item.EncryptedId, 974, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Destination/AddDestination\" class=\"btn btn-primary\">Yeni Rota Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TraversalCoreProje.Areas.Admin.Models.DestinationViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
