using Microsoft.AspNetCore.Mvc;

namespace backend_asp.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
