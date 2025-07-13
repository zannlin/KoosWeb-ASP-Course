using Microsoft.AspNetCore.Mvc;

namespace KoosWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
