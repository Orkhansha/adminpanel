#pragma checksum "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a492c230d33ce575563b2ca0ab5adec4bbaf8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Books), @"mvc.1.0.view", @"/Views/Shared/_Books.cshtml")]
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
#line 1 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a492c230d33ce575563b2ca0ab5adec4bbaf8d", @"/Views/Shared/_Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fd6bb7c7335018762291f9a99db59597b2b892", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
 foreach (var item in Model)

{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4 col-6 pt-4\">\r\n        <div class=\"input-border me-4 position-relative \">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 169, "\"", 197, 2);
            WriteAttributeValue("", 176, "/shop/detail/", 176, 13, true);
#nullable restore
#line 8 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
WriteAttributeValue("", 189, item.Id, 189, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "50a492c230d33ce575563b2ca0ab5adec4bbaf8d4576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 227, "~/assets/img/feature-collection/", 227, 32, true);
#nullable restore
#line 9 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
AddHtmlAttributeValue("", 259, item.ImageUrl, 259, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n            <h4 class=\"title fs-6 fs-sm-12 fs-sm-12 ls-1\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 394, "\"", 422, 2);
            WriteAttributeValue("", 401, "/shop/detail/", 401, 13, true);
#nullable restore
#line 12 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
WriteAttributeValue("", 414, item.Id, 414, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white  ps-3 work-sans hover2 t-5 geometric\">");
#nullable restore
#line 12 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
                                                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h4>\r\n            <span class=\"price\">\r\n                <span class=\"money text-fusion ps-3 fw-bold fs-4\" data-currency-usd=\"$39.00\">");
#nullable restore
#line 15 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
                                                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </span>
            <span class=""stars ps-3 pt-2 pb-3 d-block"">
                <i class=""fa-regular fa-star text-yellow""></i>
                <i class=""fa-regular fa-star text-yellow""></i>
                <i class=""fa-regular fa-star text-yellow""></i>
                <i class=""fa-regular fa-star text-yellow""></i>
                <i class=""fa-regular fa-star text-yellow""></i>
            </span>
            <div class=""ht-product-action "">
                <ul class=""list-unstyled d-flex align-items-center justify-content-center pt-3"">
                    <li class="" "">
                        <a href=""#"" class=""text-decoration-none hover2 t-5 text-white"" data-modal>
                            <i class=""fas fa-search fs-4"" style=""cursor: pointer;""></i>
                        </a>
                    </li>
                    <li class=""ps-4 "">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1594, "\"", 1627, 2);
            WriteAttributeValue("", 1601, "/basket/addbasket/", 1601, 18, true);
#nullable restore
#line 32 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
WriteAttributeValue("", 1619, item.Id, 1619, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-decoration-none hover2 t-5 text-white"">
                            <i class=""las la-shopping-bag fs-4"" style=""cursor: pointer;""></i>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
");
#nullable restore
#line 40 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_Books.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
