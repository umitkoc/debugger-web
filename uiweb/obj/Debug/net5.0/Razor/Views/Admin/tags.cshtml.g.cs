#pragma checksum "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\tags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8485bc3e080a3360345184242ef80130ccd8db27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_tags), @"mvc.1.0.view", @"/Views/Admin/tags.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8485bc3e080a3360345184242ef80130ccd8db27", @"/Views/Admin/tags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f73a73f63e86ab5603a280e5fd7d4e34cdab00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_tags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\tags.cshtml"
  
    Layout = "_admin";
    ViewData["title"] = "Admin | Tags";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\tags.cshtml"
         for (var i = 0; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-3 mb-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <p>title: c#</p>
                        <p>blogs: 5</p>
                        <p>date: 2020-09-09</p>
                        <hr>
                         <div class=""col-md-12 d-flex justify-content-between"">
                    <a href=""#"" class=""btn btn-outline-success""><i class=""fas fa-check-circle""></i></a>
                     <a href=""#"" class=""btn btn-outline-warning""><i class=""fas fa-check-circle""></i></a>
                </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 23 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Admin\tags.cshtml"
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
