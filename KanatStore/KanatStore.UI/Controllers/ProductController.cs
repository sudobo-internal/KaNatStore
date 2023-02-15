using KanatStore.BLL.Categories.Services;
using KanatStore.BLL.Product.Services;
using KanatStore.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace KanatStore.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRespository _productRespository;
        private readonly ICategoryRespository _categoryRespository;
        /// <summary>
        /// Tạo mới ProductController
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
            if (pro.ProductDetail == null)
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
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
                return View(pro);
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thêm mới không thành công" + ex.Message;
                return View(pro);
            }
        }
        
        //GET: Product/Edit/1
        public IActionResult Edit(int id)
        {
            if (id.ToString() == null)
                return NotFound();
            ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
            //khởi tạo product 
            ProductDetailViewModel pro = new ProductDetailViewModel();
            //lấy ra product có mã bằng id
            pro.ProductDetail = _productRespository.GetById(id);
            return View(pro);
        }

        //POST: Product/Edit/1
        //To protect from overposting attacks, enable the specific properties you want to bind to
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProductDetailViewModel pro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_productRespository.Update(pro.ProductDetail))
                    {
                        ViewBag.mess = "Sửa thành công";
                        _productRespository.Save();
                    }
                    else
                        ViewBag.mess = "Sửa thất bại";
                }
                ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thay đổi không thành công" + ex.Message;
                return View(pro.ProductDetail);
            }
        }
        //GET: Product/Edit/1
        public IActionResult Delete(int id)
        {
            if (id.ToString() == null)
                return NotFound();
            ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
            //khởi tạo product 
            ProductDetailViewModel pro = new ProductDetailViewModel();
            //lấy ra product có mã bằng id
            pro.ProductDetail = _productRespository.GetById(id);
            return View(pro);
        }

        //POST: Product/Edit/1
        //To protect from overposting attacks, enable the specific properties you want to bind to
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, ProductDetailViewModel pro)
        {
            try
            {
                
                if (_productRespository.Delete(id))
                {
                    ViewBag.mess = "Xóa thành công";
                    _productRespository.Save();
                }
                else
                    ViewBag.mess = "Xóa thất bại";
                ViewBag.CategoryId = new SelectList(_categoryRespository.GetAll(), "Id", "Name");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = "Xóa không thành công" + ex.Message;
                return View(pro.ProductDetail);
            }
        }
    }
}
