#pragma checksum "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77ed9451cd3e1eec13bb4ded01077cdb4c558c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReceitaView_getReceita), @"mvc.1.0.view", @"/Views/ReceitaView/getReceita.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReceitaView/getReceita.cshtml", typeof(AspNetCore.Views_ReceitaView_getReceita))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77ed9451cd3e1eec13bb4ded01077cdb4c558c6", @"/Views/ReceitaView/getReceita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_ReceitaView_getReceita : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebChef.Models.Receita>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UtilizadorView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReceitaFavoritos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RmReceitaFavoritos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReceitaView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReceitaSemana", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RmReceitaSemana", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfecionaReceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-passo", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
  
    ViewData["Title"] = "Informação Receita";

#line default
#line hidden
            BeginContext(85, 94, true);
            WriteLiteral("\r\n<h1>Receita</h1>\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(180, 40, false);
#line 11 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(220, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(282, 36, false);
#line 14 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(318, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(379, 45, false);
#line 17 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(424, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(486, 41, false);
#line 20 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(527, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(588, 58, false);
#line 23 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.informacao_nutricional));

#line default
#line hidden
            EndContext();
            BeginContext(646, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(708, 54, false);
#line 26 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.informacao_nutricional));

#line default
#line hidden
            EndContext();
            BeginContext(762, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(823, 52, false);
#line 29 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.duracao_prevista));

#line default
#line hidden
            EndContext();
            BeginContext(875, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(937, 48, false);
#line 32 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.duracao_prevista));

#line default
#line hidden
            EndContext();
            BeginContext(985, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\"></dt>\r\n        <dd class=\"col-sm-10\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 1084, "", 1107, 1);
#line 36 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
WriteAttributeValue("", 1090, Model.link_ajuda, 1090, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1107, 80, true);
            WriteLiteral(">Link do vídeo</a>\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1188, 46, false);
#line 40 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.nr_pessoas));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1296, 42, false);
#line 43 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.nr_pessoas));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1399, 47, false);
#line 46 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1508, 43, false);
#line 49 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.dificuldade));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1614, 45, false);
#line 53 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayNameFor(model => model.categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1721, 41, false);
#line 56 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
       Write(Html.DisplayFor(model => model.categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 107, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        \r\n    </dl>\r\n</div>\r\n<div class=\"card\">\r\n    <img class=\"card-img-top img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1869, "", 1900, 1);
#line 63 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
WriteAttributeValue("", 1874, Url.Content(Model.imagem), 1874, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1900, 42, true);
            WriteLiteral(" alt=\"Card image cap\" >\r\n</div>\r\n\r\n<div>\r\n");
            EndContext();
#line 67 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        if (ViewBag.isFavorita == false)
        {

#line default
#line hidden
            BeginContext(2043, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2055, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77ed9451cd3e1eec13bb4ded01077cdb4c558c613441", async() => {
                BeginContext(2180, 61, true);
                WriteLiteral("\r\n                Adicionar Receita a Favoritos\r\n            ");
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
#line 71 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
                                                                                 WriteLiteral(Model.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2283, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2295, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77ed9451cd3e1eec13bb4ded01077cdb4c558c616445", async() => {
                BeginContext(2419, 60, true);
                WriteLiteral("\r\n                Remover Receita de Favoritos\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
                                                                                WriteLiteral(Model.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2483, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
        }


        if (ViewBag.isSemanal == false)
        {

#line default
#line hidden
            BeginContext(2552, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2564, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77ed9451cd3e1eec13bb4ded01077cdb4c558c619478", async() => {
                BeginContext(2683, 66, true);
                WriteLiteral("\r\n                Adicionar Receita a Ementa Semanal\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
                                                                           WriteLiteral(Model.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2753, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2791, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2803, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77ed9451cd3e1eec13bb4ded01077cdb4c558c622481", async() => {
                BeginContext(2921, 65, true);
                WriteLiteral("\r\n                Remover Receita de Ementa Semanal\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
                                                                          WriteLiteral(Model.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2990, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 94 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
        }


#line default
#line hidden
            BeginContext(3005, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3013, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f77ed9451cd3e1eec13bb4ded01077cdb4c558c625454", async() => {
                BeginContext(3151, 43, true);
                WriteLiteral("\r\n            Confecionar Receita\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"
                                                                        WriteLiteral(Model.id_receita);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-passo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["passo"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3198, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "C:\Users\Barbosa\Desktop\LI4\WebChef\WebChef\Views\ReceitaView\getReceita.cshtml"


    }

#line default
#line hidden
            BeginContext(3211, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebChef.Models.Receita> Html { get; private set; }
    }
}
#pragma warning restore 1591
