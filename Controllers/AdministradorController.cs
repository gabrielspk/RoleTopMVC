using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Database;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Dashboard()
        {
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado || (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {

                var eventos = eventoRepository.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel();

                foreach (var evento in eventos)
                {
                    switch(evento.Status)
                    {
                        case (uint) StatusEvento.APROVADO:
                            dashboardViewModel.EventosAprovados++;
                            break;
                        case (uint) StatusEvento.REPROVADO:
                        dashboardViewModel.EventosReprovados++;
                        break;
                        default:
                        dashboardViewModel.EventosPendentes++;
                        dashboardViewModel.Eventos.Add(evento);
                        break;
                    }
                }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            return View(dashboardViewModel);
            }
            else
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Acesso negado, você não ter permissão para acessar o Dashboard"
                });
            }
            }
        }
    }