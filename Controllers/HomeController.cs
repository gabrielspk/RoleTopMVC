using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class HomeController : AbstractController
    {
        EventoRepository eventoRepository = new EventoRepository();
        public IActionResult Index()
        {
                DashboardViewModel dashboardViewModel = new DashboardViewModel();

                var eventos = eventoRepository.ObterTodos();
                dashboardViewModel.NomeView = "Home";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
                dashboardViewModel.Eventos = eventos;
                return View(dashboardViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
