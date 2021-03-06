#pragma checksum "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "610bd25a6833866ee6467a7fb9983116324229fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Casts_Details), @"mvc.1.0.view", @"/Views/Casts/Details.cshtml")]
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
#line 1 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/_ViewImports.cshtml"
using MovieShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/_ViewImports.cshtml"
using MovieShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"610bd25a6833866ee6467a7fb9983116324229fd", @"/Views/Casts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d2154f16347fb0df8a919e414827cd460665e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Casts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.CastDetailsResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MovieCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
  
    ViewData["Title"] = "Cast Detail Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"rounded\">\n    <div class=\"container\">\n        <div class=\"row p-5\">\n            <div class=\"col-2 offset-3\">\n                <img class=\"mr-4 rounded img-fluid w-80\"");
            BeginWriteAttribute("src", " src=\"", 285, "\"", 309, 1);
#nullable restore
#line 13 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
WriteAttributeValue("", 291, Model.ProfilePath, 291, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 310, "\"", 327, 1);
#nullable restore
#line 13 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
WriteAttributeValue("", 316, Model.Name, 316, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </div>\n            <div class=\"col\">\n                <h1");
            BeginWriteAttribute("class", " class=\"", 398, "\"", 406, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <h3>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 489, 1);
#nullable restore
#line 18 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
WriteAttributeValue("", 475, Model.TmdbUrl, 475, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-dark mx-3"">
                        <i class=""fa fa-share-square-o"" aria-hidden=""true""></i>
                    </a>
                </h3>
            </div>
        </div>
    </div>
    <div class=""container-fluid bg-light"">
        <div class=""row p-5"">
            <div class=""col offset-5"">
                <h1>
                    ");
#nullable restore
#line 29 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
                Write(Model.Gender == "1" ? "Her Movie List" : (Model.Gender == "2") ? "His Movie List" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h1>\n            </div>\n        </div>\n    </div>\n    <div class=\"container-fluid bg-light\">\n        <div class=\"row\">\n");
#nullable restore
#line 36 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
             foreach (var movie in @Model.Movies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "610bd25a6833866ee6467a7fb9983116324229fd6413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = movie;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                </div>\n");
#nullable restore
#line 42 "/Users/feli-v/Downloads/MovieShopMVC/MovieShopMVC/Views/Casts/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.CastDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
