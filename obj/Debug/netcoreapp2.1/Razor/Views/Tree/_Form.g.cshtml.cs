#pragma checksum "C:\Users\pweinberger\Desktop\banners\source\Views\Tree\_Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0d237494327851c04806d75e9cbfd9db57d634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tree__Form), @"mvc.1.0.view", @"/Views/Tree/_Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tree/_Form.cshtml", typeof(AspNetCore.Views_Tree__Form))]
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
#line 1 "C:\Users\pweinberger\Desktop\banners\source\Views\_ViewImports.cshtml"
using Basically;

#line default
#line hidden
#line 2 "C:\Users\pweinberger\Desktop\banners\source\Views\_ViewImports.cshtml"
using Basically.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0d237494327851c04806d75e9cbfd9db57d634", @"/Views/Tree/_Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c351cad88bef47036122ec8b0fdcddd4780bf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tree__Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 368, true);
            WriteLiteral(@"<text-box-input 
                validation-message=""Enter a name between 1 and 100 characters"" 
                label=""Name"" 
                :required=""true"" 
                :model=""record""
                field=""name"" 
                :max-length=""100"" 
                :min-length=""1"">
</text-box-input>
<br/>
<div><a href=""/"">Return to home</a></div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
