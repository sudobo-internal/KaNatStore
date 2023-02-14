using KanatStore.BLL.Categories.Services;
using KanatStore.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KanatStore.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRespository _categoryRespository;
        public CategoryController(ICategoryRespository categoryResporitory)
        {
           _categoryRespository= categoryResporitory;
        }
        public IActionResult Index()
        {
            CategoryViewModel cate = new CategoryViewModel();
            cate.categories = _categoryRespository.GetAll();
            return View(cate);
        }
        //GET: Category/Details/1
        public IActionResult Details(int id)
        {
            CategoryDetailViewModel category = new CategoryDetailViewModel();
            category.CategoryDetail = _categoryRespository.GetById(id);
            if (category.CategoryDetail == null)
            {
                return NotFound();
            }
            return View(category);
        }
        //GET: Category/Create
        public IActionResult Create()
        {
            CategoryDetailViewModel category = new CategoryDetailViewModel();
            return View(category);
        }

        //POST: Product/Create
        //To protect from overposting attacks, enable the specific properties you wan to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryDetailViewModel category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoryRespository.Create(category.CategoryDetail);
                    _categoryRespository.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thêm mới không thành công" + ex.Message;
                return View(category.CategoryDetail);
            }
        }

        //GET: Category/Edit/1
        public IActionResult Edit(int id)
        {
            if (id.ToString() == null)
                return NotFound();
            //khởi tạo category 
            CategoryDetailViewModel cate = new CategoryDetailViewModel();
            //lấy ra category có mã bằng id
            cate.CategoryDetail = _categoryRespository.GetById(id);
            return View(cate);
        }

        //POST: Category/Edit/1
        //To protect from overposting attacks, enable the specific properties you want to bind to
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CategoryDetailViewModel cate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_categoryRespository.Update(cate.CategoryDetail))
                    {
                        ViewBag.mess = "Sửa thành công";
                        _categoryRespository.Save();
                    }
                    else
                        ViewBag.mess = "Sửa thất bại";
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thay đổi không thành công" + ex.Message;
                return View(cate.CategoryDetail);
            }
        }
        //GET: Category/Delete/1
        public IActionResult Delete(int id)
        {
            if (id.ToString() == null)
                return NotFound();
            //khởi tạo category 
            CategoryDetailViewModel cate = new CategoryDetailViewModel();
            //lấy ra category có mã bằng id
            cate.CategoryDetail = _categoryRespository.GetById(id);
            return View(cate);
        }

        //POST: Category/Delete/1
        //To protect from overposting attacks, enable the specific properties you want to bind to
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, CategoryDetailViewModel cate)
        {
            try
            {

                if (_categoryRespository.Delete(id))
                {
                    ViewBag.mess = "Xóa thành công";
                    _categoryRespository.Save();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.mess = "Không tìm thấy danh mục hoặc danh mục chứa sản phẩm không thể xóa";
                    return View("Delete",cate);
                }
            }
            catch (Exception ex)
            {
                ViewBag.error = "Xóa không thành công" + ex.Message;
                return View(cate.CategoryDetail);
            }
        }

    }
}
