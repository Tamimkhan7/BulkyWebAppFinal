using Microsoft.AspNetCore.Mvc;

namespace BulkyWebAppFinal.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 