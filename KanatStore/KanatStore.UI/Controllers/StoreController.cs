using KanatStore.BLL.Dto;
using KanatStore.BLL.Store.Service;
using Microsoft.AspNetCore.Mvc;

namespace KanatStore.UI.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreRepository _repository;
        public StoreController(IStoreRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <returns>trả danh sách cửa hàng cho View</returns>
        public IActionResult Index()
        {
            List<StoreDto> list = _repository.GetAll();
            if(list== null || list.Count == 0)
            {
                ViewBag.message = "Chưa có cửa hàng nào được tạo";
            }
            return View(list);
        }

        public IActionResult Create()
        {
            StoreDto dto = new StoreDto();
            return View(dto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StoreDto store)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repository.Create(store);
                    _repository.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(store);
            }
            catch (Exception ex)
            {
                ViewBag.message = "Thêm mới thất bại " + ex.Message;
                return View(store);
            }
        }

        public IActionResult Edit(int id) 
        {
            StoreDto store = new StoreDto();
            store = _repository.Get(id);
            return View(store);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StoreDto store)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if(_repository.Update(store))
                    {
                        ViewBag.message = "Cập nhật thành công";
                        _repository.Save();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.message = "Cửa hàng không tồn tại!";
                        return View(store);
                    }    
                }
                return View(store);
            }
            catch(Exception ex)
            {
                ViewBag.message = "Cập nhật không thành công " + ex.Message; 
                return View(store);
            }
        }
        public IActionResult Delete(int id)
        {
            StoreDto store = new StoreDto();
            store = _repository.Get(id);
            return View(store);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(StoreDto store, int id)
        {
            try
            {
                if (_repository.Delete(id))
                {
                    ViewBag.message = "Xóa thành công";
                    _repository.Save();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.message = "Cửa hàng không tồn tại!";
                    return View(store);
                }
            }
            catch (Exception ex)
            {
                ViewBag.message = "Xóa không thành công " + ex.Message;
                return View(store);
            }
        }
    }
}
