#pragma checksum "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6222083d450d9904b6fa2214d653ad41eea4fcf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
#line 1 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\_ViewImports.cshtml"
using servico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\_ViewImports.cshtml"
using servico.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6222083d450d9904b6fa2214d653ad41eea4fcf0", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680f3c90089f61f86a62d7e8f159c93df52ab44a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemServico>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Listagem dos serviços cadastrados</h2>\r\n\r\n<table border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th>Item</th>\r\n            <th>Quantidade</th>\r\n            <th>Valor</th>\r\n        </tr>\r\n\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml"
         foreach (ItemServico item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml"
               Write(item.item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml"
               Write(item.quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml"
               Write(item.valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n<p>Total de serviços: ");
#nullable restore
#line 29 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Listagem.cshtml"
                 Write(Servico.TotalizaServico());

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemServico>> Html { get; private set; }
    }
}
#pragma warning restore 1591