#pragma checksum "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d534d09c0bb1ced63df3cf6155004b8ff646f18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\_ViewImports.cshtml"
using BerilliumTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\_ViewImports.cshtml"
using BerilliumTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\_ViewImports.cshtml"
using BerilliumTask.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\_ViewImports.cshtml"
using BerilliumTask.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d534d09c0bb1ced63df3cf6155004b8ff646f18", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1850cec3403f442e61143acf014b09df2d552f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Free Website Template by FreeHTML5.co"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"gtco-container\">\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <div class=\"owl-carousel owl-carousel-fullwidth\">\n\n");
#nullable restore
#line 8 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                 foreach (var item in Model.banners)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\n                        <a href=\"#\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d534d09c0bb1ced63df3cf6155004b8ff646f185155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 353, "~/images/", 353, 9, true);
#nullable restore
#line 12 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 362, item.Image, 362, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div class=\"slider-copy\">\n                                <h2>");
#nullable restore
#line 14 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                            </div>\n                        </a>\n                    </div>\n");
#nullable restore
#line 18 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </div>
</div>

<div class=""gtco-section"">
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2 gtco-heading text-center"">
                <h2>Work</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.</p>
            </div>
        </div>
        <div class=""row"">

            <div class=""col-md-12"">
                <div class=""owl-carousel owl-carousel-carousel"">

");
#nullable restore
#line 39 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                     foreach (var item in Model.Projects)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\n                            <div class=\"gtco-item\">\n                                <a href=\"/Projects/Index\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d534d09c0bb1ced63df3cf6155004b8ff646f188437", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1473, "~/images/", 1473, 9, true);
#nullable restore
#line 43 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1482, item.img, 1482, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                                <h2><a href=\"#\">");
#nullable restore
#line 44 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                                           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                                <p class=\"role\">");
#nullable restore
#line 45 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n");
#nullable restore
#line 48 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

        </div>
    </div>
</div>
<!-- END Work -->

<div class=""gtco-section"">
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-6 gtco-news"">
                <h2>News</h2>
                <ul>

");
#nullable restore
#line 65 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                     foreach (var item in Model.news)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <li>\n                            <a href=\"#\">\n                             <span class=\"post-date\">");
#nullable restore
#line 69 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                                                Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                              <h3>");
#nullable restore
#line 70 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                              <p>");
#nullable restore
#line 71 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                            Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </a>\n                       </li>   \n");
#nullable restore
#line 74 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </ul>\n            \n                    <p><a");
            BeginWriteAttribute("href", " href=\"", 2491, "\"", 2525, 1);
#nullable restore
#line 78 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 2498, Model.news.First().BtnLink, 2498, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-special\">");
#nullable restore
#line 78 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                                                                                       Write(Model.news.First().BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n               \n\n            </div>\n            <!-- END News -->\n\n            ");
#nullable restore
#line 84 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
       Write(Html.Raw(Model.testimonial.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("        </div>\n    </div>\n</div>\n<!-- END  -->\n\n<div class=\"gtco-section gto-features\">\n    <div class=\"gtco-container\">\n        <div class=\"row\">\n\n");
#nullable restore
#line 106 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
             foreach (var item in Model.services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\n                    <div class=\"feature-left\">\n                        <i");
            BeginWriteAttribute("class", " class=\"", 3844, "\"", 3862, 1);
#nullable restore
#line 110 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 3852, item.Icon, 3852, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                        <div class=\"copy\">\n                            <h3>");
#nullable restore
#line 112 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p>");
#nullable restore
#line 113 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p><a href=\"#\" class=\"gtco-more\">");
#nullable restore
#line 114 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
                                                        Write(item.ButtonText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 118 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
