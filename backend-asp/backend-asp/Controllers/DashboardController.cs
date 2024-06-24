using Microsoft.AspNetCore.Mvc;

namespace backend_asp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
