#pragma checksum "C:\Users\rainf\Desktop\BASIC_C#_PROGRAMS\C#_PROJECTS\C-_REPO\SUBMISSION 547\Views\Home\Time.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7068b54082dd78d51d9d0b5f9b88c539a6e60a00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Time), @"mvc.1.0.view", @"/Views/Home/Time.cshtml")]
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
#line 1 "C:\Users\rainf\Desktop\BASIC_C#_PROGRAMS\C#_PROJECTS\C-_REPO\SUBMISSION 547\Views\_ViewImports.cshtml"
using SUBMISSION_547;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rainf\Desktop\BASIC_C#_PROGRAMS\C#_PROJECTS\C-_REPO\SUBMISSION 547\Views\_ViewImports.cshtml"
using SUBMISSION_547.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7068b54082dd78d51d9d0b5f9b88c539a6e60a00", @"/Views/Home/Time.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6514bd907c3552a707737a05112edbffd37a8ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Time : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rainf\Desktop\BASIC_C#_PROGRAMS\C#_PROJECTS\C-_REPO\SUBMISSION 547\Views\Home\Time.cshtml"
  
    ViewData["Title"] = "TIME";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>The Time is: </h2>\r\n");
#nullable restore
#line 5 "C:\Users\rainf\Desktop\BASIC_C#_PROGRAMS\C#_PROJECTS\C-_REPO\SUBMISSION 547\Views\Home\Time.cshtml"
Write(DateTime.Now);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591