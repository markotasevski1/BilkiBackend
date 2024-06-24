using Microsoft.AspNetCore.Mvc;

namespace backend_asp.Controllers
{
    public class UserDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
