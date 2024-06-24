using Microsoft.AspNetCore.Mvc;

namespace backend_asp.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
