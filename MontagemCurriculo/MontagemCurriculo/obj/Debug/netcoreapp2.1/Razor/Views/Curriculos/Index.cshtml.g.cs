#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c592e0871b6fbafa9bb49bda8cc1f2503a86496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculos_Index), @"mvc.1.0.view", @"/Views/Curriculos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Curriculos/Index.cshtml", typeof(AspNetCore.Views_Curriculos_Index))]
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
#line 1 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\_ViewImports.cshtml"
using MontagemCurriculo;

#line default
#line hidden
#line 2 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\_ViewImports.cshtml"
using MontagemCurriculo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c592e0871b6fbafa9bb49bda8cc1f2503a86496", @"/Views/Curriculos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b55d53231057bb739b5260a709cc1426085b65bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MontagemCurriculo.Models.Curriculo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-small blue darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-small deep-purple darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
  
    ViewData["Title"] = "Curr??culos cadastrados";

#line default
#line hidden
            BeginContext(116, 46, true);
            WriteLiteral("\r\n<h5>Curr??culos cadastrados</h5>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5451ca013f242389460d7b1b7ff28fc", async() => {
                BeginContext(221, 14, true);
                WriteLiteral("Novo curr??culo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(239, 116, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table striped hover highlight\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(356, 40, false);
#line 16 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(396, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(531, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(592, 39, false);
#line 26 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(631, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(698, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff47afe048f64b669534186daca9bc78", async() => {
                BeginContext(788, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
                                           WriteLiteral(item.CurriculoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(801, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(825, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3ee64e2f484dee9b485e371e8be81b", async() => {
                BeginContext(925, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
                                              WriteLiteral(item.CurriculoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(937, 75, true);
            WriteLiteral(" |\r\n                    <a class=\"btn btn-small red darken-4 model-trigger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1012, "\"", 1052, 3);
            WriteAttributeValue("", 1022, "ExibirModal(", 1022, 12, true);
#line 31 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
WriteAttributeValue("", 1034, item.CurriculoId, 1034, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1051, ")", 1051, 1, true);
            EndWriteAttribute();
            BeginContext(1053, 56, true);
            WriteLiteral(">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\MontagemDeCurriculo_0074\MontagemCurriculo\MontagemCurriculo\Views\Curriculos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1120, 400, true);
            WriteLiteral(@"    </tbody>
</table>

<!-- Modal Structure -->
<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar exclus??o</h4>
        <p>Deseja prosseguir com a exclus??o?</p>
    </div>
    <div class=""modal-footer"">
        <a class=""modal-close btn green accent-4"">N??o</a>
        <a class=""modal-close btn red accent-4 btnConfirmar"">Sim</a>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1537, 662, true);
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            $("".modal"").modal();
        });

        //fun????o exibir modal
        function ExibirModal(id) {
            $(""#modal1"").modal(""open"");

            $("".btnConfirmar"").on('click', function () {
                $.ajax({
                    method: ""POST"",
                    url: ""/Curriculos/Delete"",
                    data: { id: id },
                    success: function () {
                        alert(""Exclus??o feita com sucesso"");
                        location.reload();
                    }
                });
            })
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(2202, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MontagemCurriculo.Models.Curriculo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
