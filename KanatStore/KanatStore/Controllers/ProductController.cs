using Microsoft.AspNetCore.Mvc;

namespace KanatStore.webUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
