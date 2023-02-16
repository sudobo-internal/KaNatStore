using Microsoft.AspNetCore.Mvc;

namespace KanatStore.UI.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
