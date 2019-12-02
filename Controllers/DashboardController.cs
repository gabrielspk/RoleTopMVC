using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            ViewData["NomeView"] = "Dashboard";
            return View();
        }
    }
}