#pragma checksum "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Cadastro\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34f4ce8b87459c6d6516e454f7ad0500400ee3b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Cadastro), @"mvc.1.0.view", @"/Views/Cadastro/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Cadastro.cshtml", typeof(AspNetCore.Views_Cadastro_Cadastro))]
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
#line 1 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f4ce8b87459c6d6516e454f7ad0500400ee3b5", @"/Views/Cadastro/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 240, true);
            WriteLiteral("<main>\r\n\r\n                    <section id=\"login\">\r\n                    \r\n                            <h1>Cadastre-se Aqui!</h1>\r\n                                <br>\r\n                                    <br>\r\n\r\n                            ");
            EndContext();
            BeginContext(240, 1788, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34f4ce8b87459c6d6516e454f7ad0500400ee3b53876", async() => {
                BeginContext(312, 1709, true);
                WriteLiteral(@"
                                
                                <div>
                                    <label for=""nome"">NOME COMPLETO</label>
                                    <br/>
                                    <input id=""nome"" type=""text"" maxlenth=""20"" minlength=""3"" name=""nome"" />
                                </div>
                                
                                <div>
                                    <label for=""senha"">SENHA</label>
                                    <br/>
                                    <input id=""senha"" type=""password"" maxlength=""20"" minlength=""3"" name=""senha"" />
                                </div>
                                
                                <div>
                                    <label for=""telefone"">TELEFONE</label>
                                    <br/>
                                    <input id=""telefone"" type=""tel"" maxlength=""8"" name=""telefone""/>
                                </div>

   ");
                WriteLiteral(@"                             <div>
                                    <label for=""email"">EMAIL</label>
                                    <br/>
                                    <input id=""email"" type=""email"" maxlength=""40"" name=""email""/>
                                </div>

                                <div>
                                    <label for=""CPF/CNPJ"">CPF/CNPJ</label>
                                    <br/>
                                    <input id=""CPF/CNPJ"" type=""tel"" maxlength=""11"" name=""cpf""/>
                                </div>

                                <input type=""submit""value=""ENTRAR!""/>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 9 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Cadastro\Cadastro.cshtml"
AddHtmlAttributeValue("", 267, Url.Action("CadastrarCliente", "Cadastro"), 267, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2028, 258, true);
            WriteLiteral(@"
                            </section>

                            <section id=""login"">
                
                                <br>
                
                        <br>
                            
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2286, "\'", 2324, 1);
#line 51 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Cadastro\Cadastro.cshtml"
WriteAttributeValue("", 2293, Url.Action("Login", "Cliente"), 2293, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2325, 253, true);
            WriteLiteral(">Já possui cadastro?</a>\r\n                                                \r\n                        <br>\r\n                        <br>\r\n                        <br>\r\n                        <br>\r\n                        <br>\r\n                    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
