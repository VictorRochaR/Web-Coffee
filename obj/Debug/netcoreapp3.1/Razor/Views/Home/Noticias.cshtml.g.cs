#pragma checksum "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7779574c880de52b88cfc50d3f5e43bbb798a2a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Noticias), @"mvc.1.0.view", @"/Views/Home/Noticias.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7779574c880de52b88cfc50d3f5e43bbb798a2a8", @"/Views/Home/Noticias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2176d391e2dbfc516a9b0a10779f8bb8d81f8c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Noticias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Noticia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml"
  
    ViewData["Title"] = "- Notícias";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main\">\r\n    <h3 class=\"text-white\">Confira aqui as últimas notícias sobre a nossa lan house:</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml"
         foreach (Noticia nt in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"text-white\">");
#nullable restore
#line 11 "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml"
                              Write(nt.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"text-white\">");
#nullable restore
#line 12 "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml"
                             Write(nt.corpo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-muted\">Escrito por ");
#nullable restore
#line 13 "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml"
                                         Write(nt.autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br>\r\n");
#nullable restore
#line 15 "C:\Estudos\meus\Web-Coffee\Views\Home\Noticias.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Noticia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
