#pragma checksum "C:\Users\walko\OneDrive\Pulpit\studnia\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\Views\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83973216781a6353c1b959cbc87c1fd782a17839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdvancedProgramming_Lesson2.Views.Views_Error), @"mvc.1.0.razor-page", @"/Views/Error.cshtml")]
namespace AdvancedProgramming_Lesson2.Views
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83973216781a6353c1b959cbc87c1fd782a17839", @"/Views/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c955167b9da7f537ed3fc4a4b0d1a9b7e55d96c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\walko\OneDrive\Pulpit\studnia\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\Views\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2 class=\"text-danger\">Has an error occurred while processing your request? We don\'t know.</h2>\n\n");
#nullable restore
#line 9 "C:\Users\walko\OneDrive\Pulpit\studnia\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\Views\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 12 "C:\Users\walko\OneDrive\Pulpit\studnia\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\Views\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 14 "C:\Users\walko\OneDrive\Pulpit\studnia\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\AdvancedProgramming_Lesson2\Views\Error.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
