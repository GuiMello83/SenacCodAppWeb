#pragma checksum "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Sobre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1eab3826d1c24f986a7d4eb839a8fc9e57541eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sobre), @"mvc.1.0.view", @"/Views/Home/Sobre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1eab3826d1c24f986a7d4eb839a8fc9e57541eb", @"/Views/Home/Sobre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680f3c90089f61f86a62d7e8f159c93df52ab44a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sobre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemServico>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Sobre.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Meu nome é ");
#nullable restore
#line 7 "C:\Users\guimv\Desktop\GMM\Cursos\Senac\Codificar aplicações Web\servico\Views\Home\Sobre.cshtml"
                                Write(Model.item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemServico> Html { get; private set; }
    }
}
#pragma warning restore 1591
