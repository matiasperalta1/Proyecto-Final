#pragma checksum "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f4e7a9cb572682310955a8a4a4a0b684798ca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articulos_ArticlesABMC), @"mvc.1.0.view", @"/Views/Articulos/ArticlesABMC.cshtml")]
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
#line 1 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\_ViewImports.cshtml"
using ProyectoFinalElectricidadSeret;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\_ViewImports.cshtml"
using ProyectoFinalElectricidadSeret.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f4e7a9cb572682310955a8a4a4a0b684798ca5", @"/Views/Articulos/ArticlesABMC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6136e52dd0eb77720c7c67c5ec135868227966", @"/Views/_ViewImports.cshtml")]
    public class Views_Articulos_ArticlesABMC : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Articulo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articulos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_generalData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_priceData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_stockData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_acondData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"card m-1\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f4e7a9cb572682310955a8a4a4a0b684798ca57012", async() => {
                WriteLiteral("\r\n                <div class=\"col-auto\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f4e7a9cb572682310955a8a4a4a0b684798ca57334", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 9 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArtCodart);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8f4e7a9cb572682310955a8a4a4a0b684798ca58882", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArtCodart);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-auto\">\r\n                    <button type=\"submit\" class=\"btn btn-success align-middle\"><i class=\"fas fa-check\"></i></button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"card m-1\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 20 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
             if (Model.ArtCodart == null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
           Write(Html.ActionLink(
                  "Agregar",
                  "ArticlesABMC",
                  "Articulos",
                  new { mode = "add", form = ((string)TempData["FormType"]) },
                  new { @class = "btn btn-success" }
                 ));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-secondary\" disabled>Editar</button>\r\n                <button class=\"btn btn-danger\" disabled>Eliminar</button>\r\n");
#nullable restore
#line 31 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
             if (Model.ArtCodart != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
           Write(Html.ActionLink(
                  "Agregar",
                  "ArticlesABMC",
                  "Articulos",
                  new { mode = "add" },
                  ((bool)TempData["AddButton"]) ? new { @class = "btn btn-success disabled m-1" } : new { @class = "btn btn-success m-1" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
           Write(Html.ActionLink(
                  "Editar",
                  "ArticlesABMC",
                  "Articulos",
                  new { mode = "edit", id = Model.ArtCodart },
                  ((bool)TempData["ActionButtons"]) ? new { @class = "btn btn-secondary disabled m-1" } : new { @class = "btn btn-secondary m-1" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
           Write(Html.ActionLink(
                  "Eliminar",
                  "ArticlesABMC",
                  "Articulos",
                  new { mode = "delete", id = Model.ArtCodart },
                  ((bool)TempData["ActionButtons"]) ? new { @class = "btn btn-danger disabled m-1" } : new { @class = "btn btn-danger m-1" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                                                                                                                                             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div class=\"card m-1\">\r\n        <div class=\"card-header\">\r\n            <ul class=\"nav nav-tabs\">\r\n");
#nullable restore
#line 60 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                 if (Model.ArtCodart == null && ((bool)TempData["FormMode"]) != false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item"">
                        <button class=""nav-link disabled"">Datos Generales</button>
                    </li>
                    <li class=""nav-item"">
                        <button class=""nav-link disabled"">Precios</button>
                    </li>
                    <li class=""nav-item"">
                        <button class=""nav-link disabled"">Acondicionamiento y Stock</button>
                    </li>
                    <li class=""nav-item"">
                        <button class=""nav-link disabled"">Datos Adicionales</button>
                    </li>
");
#nullable restore
#line 74 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        ");
#nullable restore
#line 78 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                   Write(Html.ActionLink(
                                 "Datos Generales",
                                 "ChangeMode",
                                 "Articulos",
                                 new { mode = "generalData" },
                                 ((string)TempData["FormType"]) == "generalData" ? new { @class = "nav-link active" } : new { @class = "nav-link " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
#nullable restore
#line 86 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                   Write(Html.ActionLink(
                                 "Precios",
                                 "ChangeMode",
                                 "Articulos",
                                 new { mode = "priceData" },
                                 ((string)TempData["FormType"]) == "priceData" ? new { @class = "nav-link active" } : new { @class = "nav-link " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
#nullable restore
#line 94 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                   Write(Html.ActionLink(
                             "Acondicionamiento y Stock",
                             "ChangeMode",
                             "Articulos",
                             new { mode = "stockData" },
                             ((string)TempData["FormType"]) == "stockData" ? new { @class = "nav-link active" } : new { @class = "nav-link " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
#nullable restore
#line 102 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                   Write(Html.ActionLink(
                             "Datos Adicionales",
                             "ChangeMode",
                             "Articulos",
                             new { mode = "adicionalData" },
                             ((string)TempData["FormType"]) == "adicionalData" ? new { @class = "nav-link active" } : new { @class = "nav-link " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 109 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div ");
#nullable restore
#line 112 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
        Write(Html.Raw(((string)TempData["FormType"]) == "generalData" ? "style = 'display: block'" : "style = 'display: none'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8f4e7a9cb572682310955a8a4a4a0b684798ca520915", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 113 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div ");
#nullable restore
#line 115 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
        Write(Html.Raw(((string)TempData["FormType"]) == "priceData" ? "style = 'display: block'" : "style = 'display: none'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8f4e7a9cb572682310955a8a4a4a0b684798ca522926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 116 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card m-2\" ");
#nullable restore
#line 118 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                         Write(Html.Raw(((string)TempData["FormType"]) == "stockData" ? "style = 'display: block'" : "style = 'display: none'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            <label class=\"m-1\">Stock</label>\r\n            <div class=\"card-body\">\r\n                <div ");
#nullable restore
#line 121 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                Write(Html.Raw(((string)TempData["FormType"]) == "stockData" ? "style = 'display: block'" : "style = 'display: none'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8f4e7a9cb572682310955a8a4a4a0b684798ca525464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 122 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"card m-2\" ");
#nullable restore
#line 126 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                         Write(Html.Raw(((string)TempData["FormType"]) == "stockData" ? "style = 'display: block'" : "style = 'display: none'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            <label class=\"m-1\">Stock</label>\r\n            <div class=\"card-body\">\r\n                <div ");
#nullable restore
#line 129 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                Write(Html.Raw(((string)TempData["FormType"]) == "stockData" ? "style = 'display: block'" : "style = 'display: none'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c8f4e7a9cb572682310955a8a4a4a0b684798ca528050", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 130 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <div class=\"row justify-content-end\">\r\n                <div class=\"col-auto\">\r\n                    ");
#nullable restore
#line 137 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
               Write(Html.ActionLink(
                         "Cancelar",
                         "CancelAction",
                         "Articulos",
                         htmlAttributes:
                         ((bool)TempData["FormMode"]) ? new { @class = "btn btn-secondary disabled" } : new { onclick = "return confirm('Seguro que desea perder los cambios?')", @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-auto\">\r\n                    <button ");
#nullable restore
#line 145 "C:\Users\Matias\Documents\GitHub\Proyecto-Final\ProyectoFinalElectricidadSeret\Views\Articulos\ArticlesABMC.cshtml"
                       Write(Html.Raw(((bool)TempData["FormMode"]) ? "disabled=\"disabled\"" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"btn btn-success\" type=\"submit\">Confirmar</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8f4e7a9cb572682310955a8a4a4a0b684798ca531252", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Articulo> Html { get; private set; }
    }
}
#pragma warning restore 1591
