#pragma checksum "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8182b7841094d7263de7737948dacdae091ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__basketPartialMobile), @"mvc.1.0.view", @"/Views/Shared/_basketPartialMobile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8182b7841094d7263de7737948dacdae091ab0", @"/Views/Shared/_basketPartialMobile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fd6bb7c7335018762291f9a99db59597b2b892", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__basketPartialMobile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("removeb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-white border hover3 t-5  py-2 d-block work-sans text-uppercase fw-semibold "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-white border hover3 t-5 py-2 d-block work-sans text-uppercase fw-semibold mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
  
    BasketVM basket = await layoutService.ShowBasket();


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
 if (layoutService.ShowBasket().Result.BasketItems.Count == 0)
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""cart-wrap"">
        <div class=""dropdown"">
            <div id=""iconCartISticky"" class=""icon "">
                <span class=""icon-cart"">
                    <svg viewBox=""0 0 32 32"" class=""t-5"" xmlns=""http://www.w3.org/2000/svg"">
                        <g id=""Layer_2"" data-name=""Layer 2"">
                            <path d=""m16 17.82a6 6 0 0 1 -5.89-4.82 1 1 0 0 1 1-1.15 1 1 0 0 1 1 .83 4 4 0 0 0 7.83 0 1 1 0 0 1 1-.83 1 1 0 0 1 1 1.15 6 6 0 0 1 -5.94 4.82z"">
                            </path>
                            <path d=""m24.9 31h-17.8a3 3 0 0 1 -3-3.15l.81-17.24a3 3 0 0 1 3-2.87h16.18a3 3 0 0 1 3 2.87l.81 17.24a3 3 0 0 1 -3 3.15zm-16.99-21.25a1 1 0 0 0 -1 1l-.81 17.2a1 1 0 0 0 1 1.05h17.8a1 1 0 0 0 1-1.05l-.81-17.24a1 1 0 0 0 -1-1z"">
                            </path>
                            <path d=""m22 8.75h-2v-1.75a4 4 0 0 0 -8 0v1.75h-2v-1.75a6 6 0 0 1 12 0z""></path>
                        </g>
                    </svg>
                    <span class=""coun");
            WriteLiteral("t-style bigcounter\">0</span>\r\n                </span>\r\n            </div>\r\n            <ul class=\"cartDropDownSticky text-start list-unstyled\">\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 1385, "\"", 1393, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""shopping-cart-content"">
                        <div class=""d-flex px-4 align-items-center justify-content-between"">
                            <h5 class=""text-white py-4"">Shopping Cart</h5>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1654, "\"", 1661, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""cart-close-sticky "">
                                <i class=""fa-regular fa-circle-xmark hover2 t-5 text-white""></i>
                            </a>
                        </div>
                        <ul class=""scrollbasket bg-myrtle"">
                            <li class=""item "">
                              
                                    <div class=""col-lg-8 shopping-cart-title"">
                                        <h4>
                                            <a   class=""text-decoration-none text-white hover2 t-5 fw-normal work-sans "">
                                                Your cart is empty
                                            </a>
                                        </h4>
                                          </div>
                                
                        </ul>
                         
                    </div>
                </li>
            </ul>
        </div>
    </div>
");
#nullable restore
#line 53 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""cart-wrap"">
        <div class=""dropdown"">
            <div id=""iconCartISticky"" class=""icon "">
                <span class=""icon-cart"">
                    <svg viewBox=""0 0 32 32"" class=""t-5"" xmlns=""http://www.w3.org/2000/svg"">
                        <g id=""Layer_2"" data-name=""Layer 2"">
                            <path d=""m16 17.82a6 6 0 0 1 -5.89-4.82 1 1 0 0 1 1-1.15 1 1 0 0 1 1 .83 4 4 0 0 0 7.83 0 1 1 0 0 1 1-.83 1 1 0 0 1 1 1.15 6 6 0 0 1 -5.94 4.82z"">
                            </path>
                            <path d=""m24.9 31h-17.8a3 3 0 0 1 -3-3.15l.81-17.24a3 3 0 0 1 3-2.87h16.18a3 3 0 0 1 3 2.87l.81 17.24a3 3 0 0 1 -3 3.15zm-16.99-21.25a1 1 0 0 0 -1 1l-.81 17.2a1 1 0 0 0 1 1.05h17.8a1 1 0 0 0 1-1.05l-.81-17.24a1 1 0 0 0 -1-1z"">
                            </path>
                            <path d=""m22 8.75h-2v-1.75a4 4 0 0 0 -8 0v1.75h-2v-1.75a6 6 0 0 1 12 0z""></path>
                        </g>
                    </svg>
                    <span class=""coun");
            WriteLiteral("t-style bigcounter\">");
#nullable restore
#line 71 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                                    Write(basket.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </span>\r\n            </div>\r\n            <ul class=\"cartDropDownSticky text-start list-unstyled\">\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 3867, "\"", 3875, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""shopping-cart-content"">
                        <div class=""d-flex px-4 align-items-center justify-content-between"">
                            <h5 class=""text-white py-4"">Shopping Cart</h5>
                            <a");
            BeginWriteAttribute("href", " href=\"", 4136, "\"", 4143, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"cart-close-sticky \">\r\n                                <i class=\"fa-regular fa-circle-xmark hover2 t-5 text-white\"></i>\r\n                            </a>\r\n                        </div>\r\n                        <ul class=\"scrollbasket bg-myrtle\">\r\n");
#nullable restore
#line 84 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                             foreach (var item in basket.BasketItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""item "" style=""list-style:none;"">
                                    <div class="" pt-3 row justify-content-between align-items-center"">
                                        <div class=""col-lg-4 shopping-cart-img position-relative text-start"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4839, "\"", 4872, 2);
            WriteAttributeValue("", 4846, "/shop/detail/", 4846, 13, true);
#nullable restore
#line 89 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
WriteAttributeValue("", 4859, item.Book.Id, 4859, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 4873, "\"", 4881, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ee8182b7841094d7263de7737948dacdae091ab013569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4943, "~/assets/img/feature-collection/", 4943, 32, true);
#nullable restore
#line 90 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
AddHtmlAttributeValue("", 4975, item.Book.ImageUrl, 4975, 19, false);

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
            WriteLiteral("\r\n                                            </a>\r\n                                            <div class=\"item-close\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8182b7841094d7263de7737948dacdae091ab015429", async() => {
                WriteLiteral("\r\n                                                    <i class=\"fa-regular fa-circle-xmark text-white\"></i>\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                                                                                 WriteLiteral(item.Book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-lg-8 shopping-cart-title"">
                                            <h4>
                                                <a");
            BeginWriteAttribute("href", " href=\"", 5726, "\"", 5759, 2);
            WriteAttributeValue("", 5733, "/shop/detail/", 5733, 13, true);
#nullable restore
#line 100 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
WriteAttributeValue("", 5746, item.Book.Id, 5746, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white hover2 t-5 fw-normal work-sans \">\r\n                                                    ");
#nullable restore
#line 101 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                               Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </h4>\r\n                                            <span class=\"text-white fw-semibold ls-1\">");
#nullable restore
#line 104 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                                                                 Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x <span class=\"money fw-semibold ls-1\">$");
#nullable restore
#line 104 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                                                                                                                     Write(item.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 108 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                        <ul class=""list-unstyled"">
                            <li class=""px-4 pb-5"">
                                <div class=""single-product-cart cart-bottom"">
                                    <div class=""shopping-cart-total py-2 border-top"">
                                        <h4 class=""text-white fw-light  work-sans d-flex justify-content-between align-items-center"">
                                            <span");
            BeginWriteAttribute("class", " class=\"", 6826, "\"", 6834, 0);
            EndWriteAttribute();
            WriteLiteral(">Total:</span>\r\n                                            <span class=\"work-sans\" data-currency-usd=\"$");
#nullable restore
#line 116 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                                                                   Write(basket.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">$");
#nullable restore
#line 116 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"
                                                                                                        Write(basket.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </h4>\r\n                                    </div>\r\n                                    <div class=\"shopping-cart-btn btn-hover text-center\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8182b7841094d7263de7737948dacdae091ab022153", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8182b7841094d7263de7737948dacdae091ab023640", async() => {
                WriteLiteral("View Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 131 "D:\Nurlan\Boake_Backend_Project\Boake-BackEnd\Views\Shared\_basketPartialMobile.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script>
    $("".removeb"").click(function (e) {
        e.preventDefault()
        console.log($(this).attr(""href""))
        Swal.fire({
            title: 'Əminsiniz?',
            text: ""Bunun geri dönüşü yoxdur!"",
            icon: 'Xəbərdarlıq',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Bəli sil!'
        }).then((result) => {
            if (result.isConfirmed) {
                var link = $(this).attr(""href"");
                fetch(link).then(response => response.json()).then(data => {
                    if (data.status == 200) {
                        location.reload(true)
                    } else {
                        Swal.fire(
                            'Tapılmadı!',
                            'Fayl silinmiş ");
            WriteLiteral("ola bilər.\',\r\n                            \'Uğursuz cəhd\'\r\n                        )\r\n                    }\r\n                });\r\n            }\r\n        })\r\n    })\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Boake_BackEnd.Services.LayoutService layoutService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
