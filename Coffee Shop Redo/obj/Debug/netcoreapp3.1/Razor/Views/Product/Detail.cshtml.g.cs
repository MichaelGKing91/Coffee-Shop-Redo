#pragma checksum "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe305e935262dc7cc1ed30dbbec3de2cfc733b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\_ViewImports.cshtml"
using Coffee_Shop_Redo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\_ViewImports.cshtml"
using Coffee_Shop_Redo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe305e935262dc7cc1ed30dbbec3de2cfc733b0", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928f11d8a8118fa9cf583b796be9474202773cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 6 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Product\Detail.cshtml"
Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h3>\r\n- ");
#nullable restore
#line 7 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Product\Detail.cshtml"
Write(Model.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n- \"");
#nullable restore
#line 9 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Product\Detail.cshtml"
Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n<br />\r\n- $");
#nullable restore
#line 11 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Product\Detail.cshtml"
Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
