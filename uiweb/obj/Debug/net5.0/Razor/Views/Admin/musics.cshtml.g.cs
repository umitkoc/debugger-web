#pragma checksum "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\musics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b289f24a69331b1b4096c5dbf085ec5096eb4f50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_musics), @"mvc.1.0.view", @"/Views/Admin/musics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b289f24a69331b1b4096c5dbf085ec5096eb4f50", @"/Views/Admin/musics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f73a73f63e86ab5603a280e5fd7d4e34cdab00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_musics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\musics.cshtml"
  
    Layout = "_admin";
    ViewData["title"] = "Admin | Musics";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\musics.cshtml"
         for (var i = 0; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-xs-3 mb-4\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <img src=\"http://placeimg.com/640/480/technics\"");
            BeginWriteAttribute("alt", " alt=\"", 373, "\"", 379, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"">
                       <p>Title:</p>
                       <p>date:</p>
                       <p>hidden:</p>
                       <p>url:</p>
                        <hr>
                        <a href=""# "" class=""btn btn-success""><i class=""fas fa-check-circle"">Approved</i></a>
                        <a href=""# "" class=""btn btn-warning""><i class=""fas fa-check-circle"">Edit</i></a>
                        <a href=""# "" class=""btn btn-danger""><i class=""fas fa-check-circle"">Delete</i></a>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 24 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\musics.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591