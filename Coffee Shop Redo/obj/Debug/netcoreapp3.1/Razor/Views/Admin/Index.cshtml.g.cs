#pragma checksum "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1b8798dcabc9454e4a7e5fe32e74b0034c184a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1b8798dcabc9454e4a7e5fe32e74b0034c184a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928f11d8a8118fa9cf583b796be9474202773cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Admin Product Index:</h1>\r\n");
#nullable restore
#line 7 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml"
 foreach (Product cur in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 11 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml"
   Write(cur);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 158, "\"", 184, 2);
            WriteAttributeValue("", 165, "/Admin/Edit/", 165, 12, true);
#nullable restore
#line 11 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml"
WriteAttributeValue("", 177, cur.id, 177, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><input type=\"button\" value=\"Edit\" /></a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 238, "\"", 266, 2);
            WriteAttributeValue("", 245, "/Admin/Delete/", 245, 14, true);
#nullable restore
#line 12 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml"
WriteAttributeValue("", 259, cur.id, 259, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><input type=\"button\" value=\"Delete\" /></a>\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Admin\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<a href=\"/Admin/AddForm/\"><input type=\"button\" value=\"Add Product\" /></a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
