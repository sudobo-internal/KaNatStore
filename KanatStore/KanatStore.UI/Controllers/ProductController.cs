using KanatStore.BLL.Product.Services;
using KanatStore.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KanatStore.UI.Controllers
{
    public class ProductController : Controller
    {
        protected readonly IProductRespository _productRespository;
        public ProductController(IProductRespository productResporitory)
        {
            _productRespository= productResporitory;
        }
        //GET: Products
        public IActionResult Index()
        {
            ProductViewModel prod = new ProductViewModel();
            prod.products = _productRespository.GetAll();
            return View(prod);
        }
        //GET: Product/Details/1
        public IActionResult Details(int id)
        {
            var result = _productRespository.GetById(id);
            if(result == null)
            {
                return NotFound();
            }
            return View(result);
        }
    }
}
