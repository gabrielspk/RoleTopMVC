using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class EventosController : Controller 
    {
        public IActionResult Eventos()
        {
            ViewData["NomeView"] = "Eventos";
            return View();
        }
    }
}