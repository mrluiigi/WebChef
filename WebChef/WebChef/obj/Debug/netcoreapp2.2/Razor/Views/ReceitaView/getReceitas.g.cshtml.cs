#pragma checksum "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2d4b907bdf8db6b6896b8ed5c0a7d02b5c89d5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2d4b907bdf8db6b6896b8ed5c0a7d02b5c89d5", @"/Views/ReceitaView/getReceitas.cshtml")]
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
#line 3 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
  
    ViewData["Title"] = "Catálogo de Receitas";

#line default
#line hidden
            BeginContext(102, 103, true);
            WriteLiteral("\r\n<h1>Receitas</h1>\r\n<div class=\"col-xs-12\" style=\"height:50px;\"></div>\r\n<table class=\"table\">\r\n    <tr");
            EndContext();
            BeginWriteAttribute("bgcolor", " bgcolor=\'", 205, "\'", 224, 1);
#line 10 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
WriteAttributeValue("", 215, "#EEE", 215, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(225, 60, true);
            WriteLiteral(">\r\n        <th>\r\n\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(286, 40, false);
#line 15 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(370, 45, false);
#line 18 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(415, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(459, 43, false);
#line 21 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.energia));

#line default
#line hidden
            EndContext();
            BeginContext(502, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(546, 52, false);
#line 24 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.duracao_prevista));

#line default
#line hidden
            EndContext();
            BeginContext(598, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(642, 46, false);
#line 27 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.link_ajuda));

#line default
#line hidden
            EndContext();
            BeginContext(688, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(732, 46, false);
#line 30 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.nr_pessoas));

#line default
#line hidden
            EndContext();
            BeginContext(778, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(822, 47, false);
#line 33 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(913, 45, false);
#line 36 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayNameFor(model => model.categoria));

#line default
#line hidden
            EndContext();
            BeginContext(958, 30, true);
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 40 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
     foreach (var receita in Model)
    {

#line default
#line hidden
            BeginContext(1032, 64, true);
            WriteLiteral("    <tr>\r\n        <td class=\"text-center\"><img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1096, "", 1129, 1);
#line 43 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
WriteAttributeValue("", 1101, Url.Content(receita.imagem), 1101, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1129, 36, true);
            WriteLiteral(" /></td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1165, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d2d4b907bdf8db6b6896b8ed5c0a7d02b5c89d58464", async() => {
                BeginContext(1254, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1273, 45, false);
#line 46 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
           Write(Html.DisplayFor(modelreceita => receita.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1318, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
                                                                     WriteLiteral(receita.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1336, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1380, 50, false);
#line 50 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayFor(modelreceita => receita.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1474, 44, false);
#line 53 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(receita.informacao_nutricional.Split("|")[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1518, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1562, 65, false);
#line 56 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayFor(modelreceita => receita.duracao_prevista_display));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 45, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1672, "", 1697, 1);
#line 59 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
WriteAttributeValue("", 1678, receita.link_ajuda, 1678, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1697, 61, true);
            WriteLiteral(">Link do vídeo</a>\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1759, 51, false);
#line 62 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayFor(modelreceita => receita.nr_pessoas));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1854, 52, false);
#line 65 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayFor(modelreceita => receita.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1950, 50, false);
#line 68 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
       Write(Html.DisplayFor(modelreceita => receita.categoria));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 30, true);
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 72 "C:\Users\jose9\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceitas.cshtml"
        }

#line default
#line hidden
            BeginContext(2041, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
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
