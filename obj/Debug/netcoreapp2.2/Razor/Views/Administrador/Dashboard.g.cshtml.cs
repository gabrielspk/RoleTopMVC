#pragma checksum "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5abe83f2e3974cd467b79f1ee700ec42cef5a9dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abe83f2e3974cd467b79f1ee700ec42cef5a9dc", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 337, true);
            WriteLiteral(@"<main>
                <h2>Dashboard</h2>
        
                <section id=""status-pedidos"">
                    <h3>Eventos Cadastrados</h3>
                    <div id=""painel"">
                        <div class=""box-status-pedidos aprovados"">
                            <h4>Aprovados</h4>
                            <p>");
            EndContext();
            BeginContext(387, 22, false);
#line 10 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                          Write(Model.EventosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(409, 185, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"box-status-pedidos pendentes\">\r\n                            <h4>Pendentes</h4>\r\n                            <p>");
            EndContext();
            BeginContext(595, 22, false);
#line 14 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                          Write(Model.EventosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(617, 187, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"box-status-pedidos reprovados\">\r\n                            <h4>Reprovados</h4>\r\n                            <p>");
            EndContext();
            BeginContext(805, 23, false);
#line 18 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                          Write(Model.EventosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(828, 1129, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </section>
        
                <section id=""lista-pedidos"">
                    <h3>Tipo de eventos</h3>
                    <table>
                        <thead>
                            <tr>
                                <th rowspan=""2"">Nome do cliente</th>
                                <th rowspan=""2"">Tipo do evento</th>
                                <th colspan=""2"">Data e hora do evento</th>
                                <th colspan=""2"" rowspan=""2"">Aprovar</th>
                            </tr>
                            <tr>
                                <th><i class=""far fa-calendar""></i></th>
                                <th><i class=""far fa-clock""></i></th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
       ");
            WriteLiteral("                         <td colspan=\"6\">\r\n                                    <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1958, 12, false);
#line 43 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                                                         Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1970, 147, true);
            WriteLiteral("</p>\r\n                                </td>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                             foreach(var evento in Model.Eventos)
                            {


#line default
#line hidden
            BeginContext(2217, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2288, 19, false);
#line 52 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                               Write(evento.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2307, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2351, 22, false);
#line 53 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                               Write(evento.TipoEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2373, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2417, 22, false);
#line 54 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                               Write(evento.Convidados.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2439, 98, true);
            WriteLiteral("</td>\r\n                                <td>14/09/2019</td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2537, "\'", 2599, 1);
#line 56 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2544, Url.Action("Aprovar", "Evento", new {id = @evento.Id}), 2544, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2600, 78, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2678, "\'", 2741, 1);
#line 57 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2685, Url.Action("Reprovar", "Evento", new {id = @evento.Id}), 2685, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2742, 75, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                            </tr>\r\n");
            EndContext();
#line 59 "C:\Users\50738510807\Desktop\RoleTopMVC\Views\Administrador\Dashboard.cshtml"
                            }

#line default
#line hidden
            BeginContext(2848, 121, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </section>\r\n        \r\n            </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
