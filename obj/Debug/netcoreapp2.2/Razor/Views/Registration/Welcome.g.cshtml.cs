#pragma checksum "C:\Users\JoshB\OneDrive\CoffeeShop-Lab18\Views\Registration\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3baca802b5525a6029f0f414a657296b5a17e447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Welcome), @"mvc.1.0.view", @"/Views/Registration/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Welcome.cshtml", typeof(AspNetCore.Views_Registration_Welcome))]
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
#line 1 "C:\Users\JoshB\OneDrive\CoffeeShop-Lab18\Views\_ViewImports.cshtml"
using CoffeeShop_Lab18;

#line default
#line hidden
#line 2 "C:\Users\JoshB\OneDrive\CoffeeShop-Lab18\Views\_ViewImports.cshtml"
using CoffeeShop_Lab18.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3baca802b5525a6029f0f414a657296b5a17e447", @"/Views/Registration/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce16fc543614d8724e7769f6dd26d7624afd268", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShop_Lab18.Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\JoshB\OneDrive\CoffeeShop-Lab18\Views\Registration\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(45, 20, true);
            WriteLiteral("\r\n<h1>Welcome</h1>\r\n");
            EndContext();
            BeginContext(103, 14, true);
            WriteLiteral("\r\n<p>Welcome, ");
            EndContext();
            BeginContext(118, 14, false);
#line 9 "C:\Users\JoshB\OneDrive\CoffeeShop-Lab18\Views\Registration\Welcome.cshtml"
       Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(132, 7, true);
            WriteLiteral(".</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShop_Lab18.Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591