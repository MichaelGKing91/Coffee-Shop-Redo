#pragma checksum "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6558328daab778f08aa46cb00f7840a57fd43b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddUser), @"mvc.1.0.view", @"/Views/Home/AddUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6558328daab778f08aa46cb00f7840a57fd43b87", @"/Views/Home/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928f11d8a8118fa9cf583b796be9474202773cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
  
    ViewData["Title"] = "AddUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 6 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
       Write(Model.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
                        Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n<h2>Account Information: </h2>\r\n<p>Username: ");
#nullable restore
#line 8 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
        Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email: ");
#nullable restore
#line 9 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
     Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Phone: ");
#nullable restore
#line 10 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
     Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Favorite Coffee: ");
#nullable restore
#line 11 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
               Write(Model.favcoffee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Favorite Pasty: ");
#nullable restore
#line 12 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
              Write(Model.favpastry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Password: ");
#nullable restore
#line 13 "C:\Users\mking10\dev\Coffee Shop Redo\Coffee Shop Redo\Views\Home\AddUser.cshtml"
        Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
