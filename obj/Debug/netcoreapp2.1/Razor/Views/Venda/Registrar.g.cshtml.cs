#pragma checksum "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0f01e1ebca313c14812c3c91ecb3a0b28a42424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Registrar), @"mvc.1.0.view", @"/Views/Venda/Registrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venda/Registrar.cshtml", typeof(AspNetCore.Views_Venda_Registrar))]
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
#line 1 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#line 2 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0f01e1ebca313c14812c3c91ecb3a0b28a42424", @"/Views/Venda/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VendaModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtTotal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ListaProdutosJSON"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Venda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 40, true);
            WriteLiteral("<h2>Registrar Venda</h2>\r\n\r\n\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(59, 2567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d34c0c8ad334eaeaf1ccddb2084f5f9", async() => {
                BeginContext(111, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(117, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbcf689604d34e08b0dd9b6a25445334", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 8 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                                              try { 

#line default
#line hidden
#line 8 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                                        WriteLiteral(ViewBag.Venda.Id);

#line default
#line hidden
#line 8 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                                                                      } catch { }

#line default
#line hidden
                WriteLiteral(" ");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(199, 72, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label>Cliente</label>\r\n        ");
                EndContext();
                BeginContext(271, 287, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71c0fb9d7c8c49498513e88045ded9d2", async() => {
                    BeginContext(321, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 12 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
              
                foreach (var item in (List<ClienteModel>)ViewBag.ListaClientes)
                {

#line default
#line hidden
                    BeginContext(439, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                    BeginContext(459, 44, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ae1a5a92534cc7b13d0669faf128b2", async() => {
                        BeginContext(485, 9, false);
#line 15 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                                        Write(item.Nome);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 15 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(503, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 16 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                }
            

#line default
#line hidden
                    BeginContext(539, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 11 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Cliente_Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(558, 16, true);
                WriteLiteral("\r\n\r\n    </div>\r\n");
                EndContext();
                BeginContext(962, 149, true);
                WriteLiteral("    <label>Produto</label>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-lg-8\">\r\n            <select class=\"form-control\" id=\"sltProduto\">\r\n");
                EndContext();
#line 39 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                  
                    foreach (var item in (List<ProdutoModel>)ViewBag.ListaProdutos)
                    {

#line default
#line hidden
                BeginContext(1239, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1263, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79b917864b18445c99349664d71f8547", async() => {
                    BeginContext(1289, 9, false);
#line 42 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                                            Write(item.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1298, 3, true);
                    WriteLiteral(" | ");
                    EndContext();
                    BeginContext(1302, 19, false);
#line 42 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                                                         Write(item.Preco_Unitario);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 42 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1330, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(1374, 886, true);
                WriteLiteral(@"
            </select>
        </div>
        <div class=""col-lg-1"">
            <input type=""text"" class=""form-control"" value=""1"" id=""txtQtde"" />
        </div>
        <div class=""col-lg-2"">
            <button type=""button"" class=""btn btn-block btn-primary"" onclick=""AdicionarProdutos()"">Adicionar</button>
        </div>
    </div>
    <br /><br />

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <td>Id</td>
                <td>Nome</td>
                <td>Quantidade</td>
                <td>Preço Unitário</td>
                <td>Preço Total</td>
            </tr>
        </thead>

        <tbody id=""listaProdutos""></tbody>
    </table>

    <br />
    <div style=""float:left; font-size:22px;"">Total: R$</div>
    <div style=""float:left; font-size:22px; margin-left:5px;"" id=""divTotal"">0.00</div>

    ");
                EndContext();
                BeginContext(2260, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa6e5523dbc649569298290b3c204b27", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 75 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Total);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2313, 27, true);
                WriteLiteral("\r\n    <br /> <br />\r\n\r\n    ");
                EndContext();
                BeginContext(2340, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0198b1ebba4652a27de2908df80af5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 78 "C:\Users\suporte\Desktop\projetos\SistemaVendas\SistemaVendas\Views\Venda\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ListaProdutos);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2429, 190, true);
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-block btn-success\">Registrar</button>\r\n    <button type=\"button\" class=\"btn btn-block btn-primary\" onclick=\"Voltar()\">Listagem de Vendas</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2626, 1812, true);
            WriteLiteral(@"

<script>
    var Itens = new Object();
    Itens.Produtos = new Array();

    var CodigoProduto = document.getElementById(""sltProduto"");
    var QtdProduto = document.getElementById(""txtQtde"");
    var ListaProdutos = document.getElementById(""listaProdutos"");
    var TotalVenda = document.getElementById(""divTotal"");
    var Total = document.getElementById(""txtTotal"");
    var ListaProdutosJSON = document.getElementById(""ListaProdutosJSON"");

    function Voltar()
    {
        window.location.href = '../Venda/Index';
    }

    function AdicionarProdutos() {

        var DescricaoPreco = CodigoProduto.options[CodigoProduto.selectedIndex].text;
        var ArrayDescricaoPreco = DescricaoPreco.split('|');
        var total = (ArrayDescricaoPreco[1].replace("","", ""."") * QtdProduto.value);
        total = Math.round(total * 100) / 100;

        Itens.Produtos.push({
            ""CodigoProduto"": CodigoProduto.value,
            ""DescricaoProduto"": ArrayDescricaoPreco[0],
            ""Q");
            WriteLiteral(@"tdProduto"": QtdProduto.value,
            ""PrecoUnitario"": ArrayDescricaoPreco[1],
            ""Total"": total
        });

        ListaProdutosJSON.innerHTML = JSON.stringify(Itens.Produtos);

        var produto = ""<tr>"" +
            ""<td>"" + CodigoProduto.value + ""</td>"" +
            ""<td>"" + ArrayDescricaoPreco[0] + ""</td>"" +
            ""<td>"" + QtdProduto.value + ""</td>"" +
            ""<td> R$"" + ArrayDescricaoPreco[1] + ""</td>"" +
            ""<td> R$"" + total + ""</td>"" +
            ""</tr>"";

        ListaProdutos.innerHTML += produto;
        var totalGeral = Math.round((TotalVenda.innerText * 1 + total) * 100) / 100;
        TotalVenda.innerHTML = totalGeral;
        txtTotal.value = totalGeral.toString().replace(""."", "","");

    }


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
