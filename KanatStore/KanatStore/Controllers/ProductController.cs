using KanatStore.BLL.Product.Services;
using KanatStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace KanatStore.webUI.Controllers
{
    public class ProductController : Controller
    {

        IProductRespository _productRepo;

        public ProductController(IProductRespository productRepo)
        {
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {
            // Lay ra toan bo san pham
            ProductViewModel productDatas = new ProductViewModel();
            productDatas.ProductDetails = _productRepo.GetAll();
            

            return View();
        }
    }
}
