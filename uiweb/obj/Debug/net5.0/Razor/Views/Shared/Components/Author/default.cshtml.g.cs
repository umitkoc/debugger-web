#pragma checksum "C:\Users\umitk\Desktop\debugger\uiweb\Views\Shared\Components\Author\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a53663eab635fe50a7e94b779de5810af0912aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Author_default), @"mvc.1.0.view", @"/Views/Shared/Components/Author/default.cshtml")]
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
#line 1 "C:\Users\umitk\Desktop\debugger\uiweb\Views\_ViewImports.cshtml"
using uiweb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umitk\Desktop\debugger\uiweb\Views\_ViewImports.cshtml"
using entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a53663eab635fe50a7e94b779de5810af0912aa", @"/Views/Shared/Components/Author/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f73a73f63e86ab5603a280e5fd7d4e34cdab00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Author_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Shared\Components\Author\default.cshtml"
 if (Model == null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-bg-danger\">Not About</div>\r\n");
#nullable restore
#line 7 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Shared\Components\Author\default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img id=\"avatar1\"");
            BeginWriteAttribute("src", " src=\"", 132, "\"", 150, 1);
#nullable restore
#line 10 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Shared\Components\Author\default.cshtml"
WriteAttributeValue("", 138, Model.image, 138, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"profile\" class=\"card-img-top rounded\">\r\n    <div class=\"card-body\">\r\n        <h5>Ümit KOÇ</h5>\r\n        <h6>Software Engineer</h6>\r\n        <h6 id=\"job1\">");
#nullable restore
#line 14 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Shared\Components\Author\default.cshtml"
                 Write(Model.job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Shared\Components\Author\default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
