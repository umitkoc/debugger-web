#pragma checksum "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1e12195d7fd9fa6fc61a92f0eace38a61425b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_music), @"mvc.1.0.view", @"/Views/Home/music.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e12195d7fd9fa6fc61a92f0eace38a61425b35", @"/Views/Home/music.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35af4810bcde93035ef49c9d4f4d87a746e0bf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_music : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MusicModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/music.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml"
  
    ViewData["title"] = "Music";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"musicList\">\r\n");
#nullable restore
#line 6 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 157, "\"", 173, 1);
#nullable restore
#line 8 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml"
WriteAttributeValue("", 162, item.Title, 162, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", "  name=\"", 174, "\"", 193, 1);
#nullable restore
#line 8 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml"
WriteAttributeValue("", 182, item.Image, 182, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 194, "\"", 211, 1);
#nullable restore
#line 8 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml"
WriteAttributeValue("", 202, item.Url, 202, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 9 "C:\Users\umitk\Desktop\debugger\uiweb\Views\Home\music.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""https://unpkg.com/wavesurfer.js""></script>


</div>
<div class=""col-md-12 mb-2"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <img id=""img"" src=""http://placeimg.com/640/480/abstract"" alt=""image"" class=""card-img-top rounded"">
                    <hr>
                     <div class=""d-flex justify-content-center"">
                        <i onclick=""Play()"" id=""play"" class=""fas fa-play-circle fa-2x""></i>
                        <i onclick=""Stop()"" class=""fas fa-stop-circle  fa-2x""></i>
                        <i onclick=""Mute()"" id=""mute"" class=""fas fa-volume-up  fa-2x""></i>
                    </div>
                </div>
                <div class=""col-md-9"">
                    <h2 id=""title"" class=""display-6"">Title</h2>
                    <p>Ümit KOÇ</p>
                    <div id=""waveform""></div>
                   <div class=""d-flex justify-content-between"">
      ");
            WriteLiteral(@"                  <i onclick=""Back()"" class=""fas fa-chevron-circle-left fa-2x""></i>
                        <i onclick=""Next()"" class=""fas fa-chevron-circle-right fa-2x""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>





");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e12195d7fd9fa6fc61a92f0eace38a61425b356221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MusicModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
