#pragma checksum "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e60bb9db90a8fc9db2b1f5d1ea00c6121a89db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReceitaView_getReceitas), @"mvc.1.0.view", @"/Views/ReceitaView/getReceitas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReceitaView/getReceitas.cshtml", typeof(AspNetCore.Views_ReceitaView_getReceitas))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e60bb9db90a8fc9db2b1f5d1ea00c6121a89db", @"/Views/ReceitaView/getReceitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_ReceitaView_getReceitas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebChef.Models.Receita>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReceitaView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getReceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
  
    ViewData["Title"] = "Catálogo de Receitas";

#line default
#line hidden
            BeginContext(102, 103, true);
            WriteLiteral("\r\n<h1>Receitas</h1>\r\n<div class=\"col-xs-12\" style=\"height:50px;\"></div>\r\n<table class=\"table\">\r\n    <tr");
            EndContext();
            BeginWriteAttribute("bgcolor", " bgcolor=\'", 205, "\'", 224, 1);
#line 10 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
WriteAttributeValue("", 215, "#EEE", 215, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(225, 29, true);
            WriteLiteral(">\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(255, 40, false);
#line 12 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(295, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(339, 45, false);
#line 15 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(428, 58, false);
#line 18 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.informacao_nutricional));

#line default
#line hidden
            EndContext();
            BeginContext(486, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(530, 52, false);
#line 21 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.duracao_prevista));

#line default
#line hidden
            EndContext();
            BeginContext(582, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(626, 46, false);
#line 24 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.link_ajuda));

#line default
#line hidden
            EndContext();
            BeginContext(672, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(716, 42, false);
#line 27 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
            EndContext();
            BeginContext(758, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(802, 46, false);
#line 30 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.nr_pessoas));

#line default
#line hidden
            EndContext();
            BeginContext(848, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(892, 47, false);
#line 33 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(939, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(983, 45, false);
#line 36 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 30, true);
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 40 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
     foreach (var receita in Model)
    {

#line default
#line hidden
            BeginContext(1102, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1150, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6e60bb9db90a8fc9db2b1f5d1ea00c6121a89db8446", async() => {
                BeginContext(1206, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1229, 45, false);
#line 45 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
               Write(Html.DisplayFor(modelreceita => receita.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1274, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1296, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1352, 50, false);
#line 49 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1458, 63, false);
#line 52 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.informacao_nutricional));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1577, 57, false);
#line 55 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.duracao_prevista));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1690, 51, false);
#line 58 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.link_ajuda));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1797, 47, false);
#line 61 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.imagem));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1900, 51, false);
#line 64 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.nr_pessoas));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2007, 52, false);
#line 67 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2115, 50, false);
#line 70 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.categoria));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Utilizador\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
        }

#line default
#line hidden
            BeginContext(2214, 18, true);
            WriteLiteral("\r\n\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebChef.Models.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591