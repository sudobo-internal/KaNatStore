using KanatStore.BLL.Categories.Services;
using KanatStore.BLL.Product.Services;
using KanatStore.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KanatStore.UI.Controllers
{
    public class ProductController : Controller
    {
        protected readonly IProductRespository _productRespository;
        protected readonly ICategoryRespository _categoryRespository;
        public ProductController(IProductRespository productResporitory, ICategoryRespository categoryRespository)
        {
            _productRespository= productResporitory;
            _categoryRespository= categoryRespository;
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
            ProductViewModel pro = new ProductViewModel();
            pro.productDetail = _productRespository.GetById(id);
            if(pro.productDetail == null || id == null)
            {
                return NotFound();
            }
            return View(pro);
        }
        //GET: Product/Create
        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
            return View();
        }

        //POST: Product/Create
        //To protect from overposting attacks, enable the specific properties you wan to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Length,Width,Thickness,Origin,Image,Price,ImportPrice,Quantity,Unit,Status,Description,CategoryId")] ProductViewModel pro)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _productRespository.Create(pro.productDetail);
                    _productRespository.Save();
                }
                ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thêm mới không thành công" + ex.Message;
                return View(pro.productDetail);
            }
        }
    }
}
