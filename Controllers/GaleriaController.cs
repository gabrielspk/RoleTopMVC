using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : Controller 
    {
        public IActionResult Galeria()
        {
            ViewData["NomeView"] = "Galeria";
            return View();
        }
    }
}