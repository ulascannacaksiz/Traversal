#pragma checksum "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1883df58fc02aa56b8f6196294c677698f185dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
#line 1 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1883df58fc02aa56b8f6196294c677698f185dfa", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Destination>
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
#line 2 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
  
    ViewData["Title"] = "DestinationDetails";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1883df58fc02aa56b8f6196294c677698f185dfa3793", async() => {
                WriteLiteral(@"
    
    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Tur Detayları</h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index/"">Anasayfa</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rehberin Yorumları </li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //about breadcrumb -->
    <!--/blog-->
");
#nullable restore
#line 22 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 818, "\"", 846, 1);
#nullable restore
#line 24 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 826, Model.DestinationId, 826, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""did"">
        <div class=""py-5 w3l-homeblock1 text-center"">
            <div class=""container mt-md-3"">
                <h3 class=""blog-desc-big text-center mb-4"">
                    Your Blog Posts are Boring? Here are 9 Tips for
                    Making your Writing more Interesting
                </h3>
                <div class=""blog-post-align"">
                    <div class=""blog-post-img"">
                        <a href=""#""><img src=""/Traversal-Starter/assets/images/c1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 1352, "\"", 1358, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle img-fluid"" /></a>
                    </div>
                    <div class=""blog-post-info"">
                        <div class=""author align-items-center mb-1"">
                            <a href=""#"">Johnson smith</a> in <a href=""#url"">Traversal</a>
                        </div>
                        <ul class=""blog-meta"">
                            <li class=""meta-item blog-lesson"">
                                <span class=""meta-value""> June 13, 2020 </span>
                            </li>
                            <li class=""meta-item blog-students"">
                                <span class=""meta-value""> 6min read</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <section class=""blog-post-main w3l-homeblock1"">
            <!--/blog-post-->
            <div class=""blog-content-inf pb-5"">
                <div class=""container pb-lg-4"">
 ");
                WriteLiteral("                   <div class=\"single-post-image\">\r\n                        <div class=\"post-content\">\r\n                            <img src=\"/Traversal-Starter/assets/images/banner2.jpg\" class=\"radius-image img-fluid mb-5\"");
                BeginWriteAttribute("alt", " alt=\"", 2606, "\"", 2612, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-post-content\">\r\n                        <p class=\"alphabet mb-4\">\r\n\r\n                            <span class=\"big-letter\"> ");
#nullable restore
#line 63 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                                                  Write(
                            Model.Details1.Length > 0 ? Model.Details1.Substring(1, 1) : ""
                            );

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>");
#nullable restore
#line 65 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                                 Write(
                        Model.Details1.Length > 0 ? Model.Details1.Substring(2) : "İçerik bulunamadı"
                        );

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </p>

                        <blockquote class=""blockquote my-5"">
                            <div class=""icon-quote""><span class=""fa fa-quote-left"" aria-hidden=""true""></span></div>
                            Lorem ipsum dolor sit amet,Ea consequuntur illum facere aperiam sequi optio consectetur.Ea
                            consequuntur illum facere aperiam sequi optio consectetur adipisicing elitFuga, suscipit
                            totam animi, dolores magnam assumenda soluta odit harum.
                            <footer class=""blockquote-footer mt-3"">
                                Smith lara
                            </footer>
                        </blockquote>

                        <div class=""sing-post-thumb mb-5 row pt-3"">
                            <div class=""col-sm-6"">
                                <a href=""#url""><img");
                BeginWriteAttribute("src", " src=\"", 4008, "\"", 4026, 1);
#nullable restore
#line 82 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 4014, Model.Image, 4014, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 4058, "\"", 4064, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            </div>\r\n                            <div class=\"col-sm-6 mt-sm-0 mt-3\">\r\n                                <a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=\"", 4224, "\"", 4243, 1);
#nullable restore
#line 85 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 4230, Model.Image2, 4230, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 4275, "\"", 4281, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            </div>\r\n                        </div>\r\n                        <h3 class=\"blog-desc-big m-0 mb-lg-4 mb-3\">Lorem ipsum dolor sit</h3>\r\n                        <p class=\"mb-4\">\r\n                            ");
#nullable restore
#line 90 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                       Write(Model.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </p>




                        <div class=""d-grid left-right mt-5 pb-md-5"">
                            <div class=""buttons-singles tags"">
                                <h4>Tags :</h4>
                                <a href=""#blog-tag"">Travel</a>
                                <a href=""#blog-tag"">Culture</a>
                                <a href=""#blog-tag"">Hotel</a>
                                <a href=""#blog-tag"">Food</a>
                            </div>
                            <div class=""buttons-singles"">
                                <h4>Share :</h4>
                                <a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                                <a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                                <a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                                <a href=""#blog-share""><");
                WriteLiteral(@"span class=""fa fa-pinterest-p"" aria-hidden=""true""></span></a>
                            </div>
                        </div>

                        <!--//author-card-->
                        <div class=""author-card mt-5"">
                            <div class=""row align-items-center"">
                                <div class=""col-sm-3 col-6"">
                                    <div>
                                        <img src=""/Traversal-Starter/assets/images/c3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6057, "\"", 6063, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""rounded-circle img-fluid"">
                                    </div>
                                </div>
                                <div class=""col-sm-9 mt-sm-0 mt-3"">
                                    <h3 class=""mb-3 title"">Alexander Ronald</h3>
                                    <p>
                                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, sed et excepturi.
                                        Distinctio fugit odit? Fugit ipsam. Lorem ipsum dolor sit.
                                    </p>
                                    <ul class=""author-icons mt-4"">
                                        <li>
                                            <a class=""facebook"" href=""#url"">
                                                <span class=""fa fa-facebook""
                                                  aria-hidden=""true""></span>
                                            </a>
                                        </li>");
                WriteLiteral(@"
                                        <li>
                                            <a class=""twitter"" href=""#url"">
                                                <span class=""fa fa-twitter""
                                                  aria-hidden=""true""></span>
                                            </a>
                                        </li>
                                        <li>
                                            <a class=""google"" href=""#url"">
                                                <span class=""fa fa-google-plus""
                                                  aria-hidden=""true""></span>
                                            </a>
                                        </li>
                                        <li>
                                            <a class=""linkedin"" href=""#url"">
                                                <span class=""fa fa-linkedin""
                                                  aria-hidden=""true");
                WriteLiteral(@"""></span>
                                            </a>
                                        </li>
                                        <li>
                                            <a class=""github"" href=""#url"">
                                                <span class=""fa fa-github""
                                                  aria-hidden=""true""></span>
                                            </a>
                                        </li>
                                        <li>
                                            <a class=""dribbble"" href=""#url"">
                                                <span class=""fa fa-dribbble""
                                                  aria-hidden=""true""></span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
               ");
                WriteLiteral("         <!--//author-card-->\r\n\r\n                        ");
#nullable restore
#line 170 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                   Write(await Component.InvokeAsync("_CommentList",new {id = Model.DestinationId}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 171 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                   Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <!--//blog-post-->\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 179 "C:\Users\UlasCan\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Destination> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
