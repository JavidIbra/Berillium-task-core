#pragma checksum "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Shared\_NewsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971461c821e74974b9881263a95c13ee0822d0c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewsPartial), @"mvc.1.0.view", @"/Views/Shared/_NewsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971461c821e74974b9881263a95c13ee0822d0c3", @"/Views/Shared/_NewsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1850cec3403f442e61143acf014b09df2d552f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NewsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Shared\_NewsPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <a href=\"#\">\r\n            <span class=\"post-date\">");
#nullable restore
#line 7 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Shared\_NewsPartial.cshtml"
                               Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h3>");
#nullable restore
#line 8 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Shared\_NewsPartial.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 9 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Shared\_NewsPartial.cshtml"
          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 12 "C:\Users\Javid\Desktop\BerilliumTask\BerilliumTask\BerilliumTask\Views\Shared\_NewsPartial.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
