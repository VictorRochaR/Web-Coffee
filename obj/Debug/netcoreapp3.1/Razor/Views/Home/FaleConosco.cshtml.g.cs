#pragma checksum "C:\Estudos\meus\Web-Coffee\Views\Home\FaleConosco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17e3a59839f0c16b76d67d6ac6125456b4b534f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FaleConosco), @"mvc.1.0.view", @"/Views/Home/FaleConosco.cshtml")]
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
#line 1 "C:\Estudos\meus\Web-Coffee\Views\_ViewImports.cshtml"
using ATV3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17e3a59839f0c16b76d67d6ac6125456b4b534f", @"/Views/Home/FaleConosco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2176d391e2dbfc516a9b0a10779f8bb8d81f8c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_FaleConosco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Estudos\meus\Web-Coffee\Views\Home\FaleConosco.cshtml"
  
    ViewData["Title"] = "- Serviços";
    var message = ViewBag.SuccessMsg;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main text-white form-group"">
        <form action=""/Home/Form"" method=""post"">
            <label for=""name"">Seu nome:</label>
            <input type=""text"" class=""form-control"" name=""name""/> </br>
          
            <label for=""email"">Seu e-mail:</label>
            <input type=""email"" class=""form-control"" name=""email""/> </br>
          
            <label for=""message"">Mensagem:</label>
            <textarea class=""form-control"" name=""message""></textarea> </br>
          
            <input type=""submit"" class=""btn btn-primary"" value=""Enviar"" />
    </form>

    <script>
    var message = '");
#nullable restore
#line 21 "C:\Estudos\meus\Web-Coffee\Views\Home\FaleConosco.cshtml"
              Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    if(message){\r\n        alert(message);\r\n    }\r\n</script>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
