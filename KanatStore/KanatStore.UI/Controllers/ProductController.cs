using KanatStore.BLL.Categories.Services;
using KanatStore.BLL.Product.Services;
using KanatStore.DAL.Entities;
using KanatStore.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KanatStore.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRespository _productRespository;
        private readonly ICategoryRespository _categoryRespository;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="productResporitory"></param>
        /// <param name="categoryRespository"></param>
        public ProductController(IProductRespository productResporitory, ICategoryRespository categoryRespository)
        {
            _productRespository = productResporitory;
            _categoryRespository = categoryRespository;
        }
       
        //GET: Products
        public IActionResult Index()
        {
            ProductViewModel prod = new ProductViewModel();
            prod.Products = _productRespository.GetAll();
            return View(prod);
        }
        //GET: Product/Details/1
        public IActionResult Details(int id)
        {
            ProductDetailViewModel pro = new ProductDetailViewModel();
            pro.ProductDetail = _productRespository.GetById(id);
            if (pro.ProductDetail == null || id == null)
            {
                return NotFound();
            }
            return View(pro);
        }
        //GET: Product/Create
        public IActionResult Create()
        {
            //khoi tao viewmodel truyen vao view
            ProductDetailViewModel product = new ProductDetailViewModel();
            product.ProductDetail = new BLL.Dto.ProductDto();
            ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
            return View(product);
        }

        //POST: Product/Create
        //To protect from overposting attacks, enable the specific properties you wan to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductDetailViewModel pro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productRespository.Create(pro.ProductDetail);
                    _productRespository.Save();
                }
                ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thêm mới không thành công" + ex.Message;
                return View(pro.ProductDetail);
            }
        }
    }
}
