#pragma checksum "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Shared\Components\ShopingCartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f82bb8531d62577284e9f6fb0660343c2fcb26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShopingCartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShopingCartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShopingCartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ShopingCartSummary_Default))]
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
#line 1 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f82bb8531d62577284e9f6fb0660343c2fcb26", @"/Views/Shared/Components/ShopingCartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db0590aa26d7d7df8b811f5bd58387e80c4e922", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShopingCartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout__btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart__btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Shared\Components\ShopingCartSummary\Default.cshtml"
 if (Model.ShopingCart.ShopingCartItems.Count >= 0)
{

#line default
#line hidden
            BeginContext(87, 96, true);
            WriteLiteral("    <li class=\"shopcart\">\r\n        <a class=\"cartbox_active\" href=\"#\"><span class=\"product_qun\">");
            EndContext();
            BeginContext(184, 40, false);
#line 6 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Shared\Components\ShopingCartSummary\Default.cshtml"
                                                                Write(Model.ShopingCart.ShopingCartItems.Count);

#line default
#line hidden
            EndContext();
            BeginContext(224, 367, true);
            WriteLiteral(@"</span></a>
        <!-- Start Shopping Cart -->
        <div class=""block-minicart minicart__active"">
            <div class=""minicart-content-wrapper"">
                <div class=""micart__close"">
                    <span>close</span>
                </div>
                <div class=""items-total d-flex justify-content-between"">
                    <span>");
            EndContext();
            BeginContext(592, 40, false);
#line 14 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Shared\Components\ShopingCartSummary\Default.cshtml"
                     Write(Model.ShopingCart.ShopingCartItems.Count);

#line default
#line hidden
            EndContext();
            BeginContext(632, 168, true);
            WriteLiteral(" items</span>\r\n                    <span>Cart Subtotal</span>\r\n                </div>\r\n                <div class=\"total_amount text-right\">\r\n                    <span>");
            EndContext();
            BeginContext(801, 36, false);
#line 18 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Shared\Components\ShopingCartSummary\Default.cshtml"
                     Write(Model.ShopingCartTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(837, 105, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"mini_action checkout\">\r\n                    ");
            EndContext();
            BeginContext(942, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bfe72fb9af14e49b0b928e16c877a87", async() => {
                BeginContext(1012, 14, true);
                WriteLiteral("Go to Checkout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1030, 3709, true);
            WriteLiteral(@"
                </div>
                <!--
                    <div class=""single__items"">
                        <div class=""miniproduct"">
                            <div class=""item01 d-flex"">
                                <div class=""thumb"">
                                    <a href=""product-details.html""><img src=""images/product/sm-img/1.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h6><a href=""product-details.html"">Voyage Yoga Bag</a></h6>
                                    <span class=""prize"">$30.00</span>
                                    <div class=""product_prize d-flex justify-content-between"">
                                        <span class=""qun"">Qty: 01</span>
                                        <ul class=""d-flex justify-content-end"">
                                            <li><a href=""#""><i class=""zmdi zmdi-settings""></i></a></li>
              ");
            WriteLiteral(@"                              <li><a href=""#""><i class=""zmdi zmdi-delete""></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""item01 d-flex mt--20"">
                                <div class=""thumb"">
                                    <a href=""product-details.html""><img src=""images/product/sm-img/3.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h6><a href=""product-details.html"">Impulse Duffle</a></h6>
                                    <span class=""prize"">$40.00</span>
                                    <div class=""product_prize d-flex justify-content-between"">
                                        <span class=""qun"">Qty: 03</span>
                                        <ul class=""d-flex justify-content-end"">
     ");
            WriteLiteral(@"                                       <li><a href=""#""><i class=""zmdi zmdi-settings""></i></a></li>
                                            <li><a href=""#""><i class=""zmdi zmdi-delete""></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""item01 d-flex mt--20"">
                                <div class=""thumb"">
                                    <a href=""product-details.html""><img src=""images/product/sm-img/2.jpg"" alt=""product images""></a>
                                </div>
                                <div class=""content"">
                                    <h6><a href=""product-details.html"">Compete Track Tote</a></h6>
                                    <span class=""prize"">$40.00</span>
                                    <div class=""product_prize d-flex justify-content-between"">
                                        <s");
            WriteLiteral(@"pan class=""qun"">Qty: 03</span>
                                        <ul class=""d-flex justify-content-end"">
                                            <li><a href=""#""><i class=""zmdi zmdi-settings""></i></a></li>
                                            <li><a href=""#""><i class=""zmdi zmdi-delete""></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                -->
                <div class=""mini_action cart"">
                    ");
            EndContext();
            BeginContext(4739, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0be2614d96d84d5d84100e8aa0681bcd", async() => {
                BeginContext(4808, 18, true);
                WriteLiteral("View and edit cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4830, 133, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- End Shopping Cart -->\r\n    </li><!--Shoping Cart View-->\r\n");
            EndContext();
#line 84 "C:\Users\Mad Coder\Documents\Visual Studio 2019\Projects\BookStore\BookStore\Views\Shared\Components\ShopingCartSummary\Default.cshtml"
}


#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
