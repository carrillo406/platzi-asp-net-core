#pragma checksum "C:\users\cac4ju\Desktop\c#\platzi-asp-net-core\Views\Shared\AsignaturaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b106fc1278a3625dc6e69397619854814c9ffa7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AsignaturaSimple), @"mvc.1.0.view", @"/Views/Shared/AsignaturaSimple.cshtml")]
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
#line 1 "C:\users\cac4ju\Desktop\c#\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\users\cac4ju\Desktop\c#\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b106fc1278a3625dc6e69397619854814c9ffa7c", @"/Views/Shared/AsignaturaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa5759f893e3c062982c7ef96ef27fe37864c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AsignaturaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Nombre: ");
#nullable restore
#line 3 "C:\users\cac4ju\Desktop\c#\platzi-asp-net-core\Views\Shared\AsignaturaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </br>\r\n    Id: ");
#nullable restore
#line 4 "C:\users\cac4ju\Desktop\c#\platzi-asp-net-core\Views\Shared\AsignaturaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591