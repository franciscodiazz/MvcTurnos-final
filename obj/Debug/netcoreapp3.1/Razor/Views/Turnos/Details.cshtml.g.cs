#pragma checksum "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127f686a1cbf817609c6bc761ca2cd8db175ce15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Turnos_Details), @"mvc.1.0.view", @"/Views/Turnos/Details.cshtml")]
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
#line 1 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\_ViewImports.cshtml"
using MvcTurnos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\_ViewImports.cshtml"
using MvcTurnos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127f686a1cbf817609c6bc761ca2cd8db175ce15", @"/Views/Turnos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21417b2cc0a2fb34db5dd047927d5fda79421070", @"/Views/_ViewImports.cshtml")]
    public class Views_Turnos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcTurnos.Models.Turno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("material-icons  mdc-icon-button sidebar-toggler"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127f686a1cbf817609c6bc761ca2cd8db175ce154326", async() => {
                WriteLiteral("\r\n    keyboard_backspace\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h2 style=""text-anchor: middle; text-align: center;"">Detalle</h2>

<hr />

<div class=""body-wrapper"">

    <div class=""page-wrapper mdc-toolbar-fixed-adjust"">
        <main class=""content-wrapper"">
            <div class=""mdc-layout-grid"">
               

                <div class=""mdc-layout-grid__cell stretch-card mdc-layout-grid__cell--span-12"">
                    <div class=""mdc-layout-grid"">
                        <div class=""mdc-layout-grid__inner"">
                            <div class=""mdc-layout-grid__cell--span-12"">
                                <div class=""mdc-card"">
                                    <dl class=""row"">
                                        <dt class=""col-sm-2"" style=""color: blue; font-size: 20px; font-weight: bold;"">
                                            ");
#nullable restore
#line 29 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Asunto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 32 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Asunto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\" style=\"color: blue; font-size: 20px; font-weight: bold;\">\r\n                                            ");
#nullable restore
#line 35 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 38 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\" style=\"color: blue; font-size: 20px; font-weight: bold;\">\r\n                                            ");
#nullable restore
#line 41 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 44 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                        <dt class=""col-sm-2"" style=""color: blue; font-size: 20px; font-weight: bold;"">
                                            Cedula
                                        </dt>
                                        <dd class=""col-sm-10"">
                                            ");
#nullable restore
#line 50 "C:\Users\pache\Desktop\proyecto final dotnet\MvcTurnos\Views\Turnos\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.UsuarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                            </div>
                        </div>
                    </div>
        </main>

    </div>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcTurnos.Models.Turno> Html { get; private set; }
    }
}
#pragma warning restore 1591
