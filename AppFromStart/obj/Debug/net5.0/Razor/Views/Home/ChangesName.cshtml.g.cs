#pragma checksum "D:\MOC\20486D\13Dec2021\AppFromStart\Views\Home\ChangesName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a38f86fae0f05d4134c829696c6b8964a958f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChangesName), @"mvc.1.0.view", @"/Views/Home/ChangesName.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a38f86fae0f05d4134c829696c6b8964a958f72", @"/Views/Home/ChangesName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChangesName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppFromStart.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MOC\20486D\13Dec2021\AppFromStart\Views\Home\ChangesName.cshtml"
  
    ViewData["Title"] = "Student in Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    Hello from the view\r\n</h1>\r\n");
#nullable restore
#line 9 "D:\MOC\20486D\13Dec2021\AppFromStart\Views\Home\ChangesName.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 11 "D:\MOC\20486D\13Dec2021\AppFromStart\Views\Home\ChangesName.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n");
#nullable restore
#line 14 "D:\MOC\20486D\13Dec2021\AppFromStart\Views\Home\ChangesName.cshtml"
Write(Html.EditorFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppFromStart.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
