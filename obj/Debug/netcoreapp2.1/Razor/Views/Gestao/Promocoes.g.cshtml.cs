#pragma checksum "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888f8a9b61fb6f53be4f7fbace3e683668468782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Promocoes), @"mvc.1.0.view", @"/Views/Gestao/Promocoes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestao/Promocoes.cshtml", typeof(AspNetCore.Views_Gestao_Promocoes))]
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
#line 1 "/home/leandro/dotnet-projects/dashpag/Views/_ViewImports.cshtml"
using sonmarket;

#line default
#line hidden
#line 2 "/home/leandro/dotnet-projects/dashpag/Views/_ViewImports.cshtml"
using sonmarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888f8a9b61fb6f53be4f7fbace3e683668468782", @"/Views/Gestao/Promocoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9668c8b60a8f669335ff45d2f33d4d9e11d2157", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Promocoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sonmarket.Models.Promocao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaPromocao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Promocoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(84, 752, true);
            WriteLiteral(@"<script>
    $(document).ready( function () {
        $('#promocoes').DataTable({
            ""info"" : false,
            ""language"": {
                ""lengthMenu"": ""Mostrando _MENU_ registros por p??gina"",
                ""zeroRecords"": ""Desculpa, Nada encontrado."",
                ""info"": ""Mostando p??gina _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nenhum registro dispon??vel"",
                ""search"":         ""Buscar:"",
                ""paginate"": {
                    ""first"":      ""Primeiro"",
                    ""last"":       ""??ltimo"",
                    ""next"":       ""Pr??ximo"",
                    ""previous"":   ""Anterior""
                }
            }
        });
    });
</script>
<h2>Promo????es</h2>
<hr/>
");
            EndContext();
            BeginContext(836, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7973a714ca8b404f925c2f515c470367", async() => {
                BeginContext(914, 19, true);
                WriteLiteral("Criar nova promo????o");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(937, 291, true);
            WriteLiteral(@"
<hr/>

<table id=""promocoes"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Produto</th>
            <th>Porcentagem</th>
            <th>A????es</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 41 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
         foreach(var promocao in Model){

#line default
#line hidden
            BeginContext(1270, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1309, 11, false);
#line 43 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
               Write(promocao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1320, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1348, 13, false);
#line 44 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
               Write(promocao.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1389, 21, false);
#line 45 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
               Write(promocao.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1438, 20, false);
#line 46 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
               Write(promocao.Porcentagem);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 72, true);
            WriteLiteral("%</td>\r\n                <td>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1530, "\"", 1572, 2);
            WriteAttributeValue("", 1537, "/Gestao/EditarPromocao/", 1537, 23, true);
#line 48 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
WriteAttributeValue("", 1560, promocao.Id, 1560, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1573, 31, true);
            WriteLiteral(">Editar</a>  \r\n                ");
            EndContext();
            BeginContext(1604, 255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ed5599606b48e19ec4f911a2a646c2", async() => {
                BeginContext(1683, 60, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1743, "\"", 1763, 1);
#line 50 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
WriteAttributeValue("", 1751, promocao.Id, 1751, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1764, 88, true);
                WriteLiteral(">\r\n                    <button class=\"btn btn-danger\">Deletar</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1859, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "/home/leandro/dotnet-projects/dashpag/Views/Gestao/Promocoes.cshtml"
        }

#line default
#line hidden
            BeginContext(1914, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sonmarket.Models.Promocao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
