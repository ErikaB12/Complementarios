#pragma checksum "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786ca8572cecc4776047c0cb9d0a812244428745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786ca8572cecc4776047c0cb9d0a812244428745", @"/Views/Home/Info.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuiaEpisodiosSimpson.Models.Episodio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
   Layout = "Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
 foreach (var episodio in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card2\">\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 174, "\"", 203, 1);
#nullable restore
#line 7 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
WriteAttributeValue("", 182, episodio.IdTemporada, 182, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <h1 class=\"tittle\">");
#nullable restore
#line 8 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
                      Write(episodio.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <span class=\"totalchapters\">");
#nullable restore
#line 9 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
                               Write(episodio.IdTemporadaNavigation.Temporada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <p class=\"description\">");
#nullable restore
#line 10 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
                          Write(episodio.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\SirVi\source\repos\GuiaEpisodiosSimpson\GuiaEpisodiosSimpson\Views\Home\Info.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuiaEpisodiosSimpson.Models.Episodio>> Html { get; private set; }
    }
}
#pragma warning restore 1591