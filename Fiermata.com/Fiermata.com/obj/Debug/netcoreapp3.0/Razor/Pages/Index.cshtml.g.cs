#pragma checksum "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6ab4105a0718be35d8022e565bfa8b87f988d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fiermata.com.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Fiermata.com.Pages
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
#line 1 "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\_ViewImports.cshtml"
using Fiermata.com;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6ab4105a0718be35d8022e565bfa8b87f988d8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c10c57066835cffe99600a7ad6be42a17970aac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Firmata</h1>\r\n    <p>Lets get you where you want to go.</p>\r\n</div>\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 12 "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\Index.cshtml"
     foreach (var bus in Model.Buses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 330, "\"", 374, 4);
            WriteAttributeValue("", 338, "background-image:", 338, 17, true);
            WriteAttributeValue(" ", 355, "url(\'", 356, 6, true);
#nullable restore
#line 15 "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\Index.cshtml"
WriteAttributeValue("", 361, bus.Image, 361, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 371, "\');", 371, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\Index.cshtml"
                                  Write(bus.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\admin\source\repos\Fiermata.com\Fiermata.com\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
