#pragma checksum "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbec4538f75731f934cce8e562f8bbc334b27df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ReservationUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbec4538f75731f934cce8e562f8bbc334b27df4", @"/Areas/Admin/Views/User/ReservationUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_ReservationUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
  
    ViewData["Title"] = "ReservationUser";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcının geçmiş rezervasyonları</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Misafir Ad soyad</th>
        <th>Rota</th>
        <th>Kişi Sayısı</th>
        <th>Tarih</th>
        <th>Durum</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n");
#nullable restore
#line 23 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
              count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("           <td>");
#nullable restore
#line 24 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
          Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("           <td>#####</td>\r\n           <td>");
#nullable restore
#line 27 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
          Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 28 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
          Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
           Write(item.ReservationDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n           <td>");
#nullable restore
#line 34 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
          Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 877, "\"", 884, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Detay gör</a></td>\r\n       </tr>\n");
#nullable restore
#line 37 "C:\Users\ulas.nacaksiz\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\ReservationUser.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591