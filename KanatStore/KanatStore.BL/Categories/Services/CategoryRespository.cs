using KanatStore.DAL;
using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Categories.Services
{
    public class CategoryRespository : ICategoryRespository, CommonRepository
    {
        protected readonly KanatStoreDBContext _dbContext;
        public CategoryRespository(KanatStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Tạo mới danh mục
        /// </summary>
        /// <param name="category"></param>
        public void Create(Category category)
        {
            _dbContext.Categories.Add(category);
        }
        /// <summary>
        /// Xóa danh mục
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        public bool Delete(int id)
        {
            Category find = _dbContext.Categories.Find(id);
            int dem = (from p in _dbContext.Products
                       join c in _dbContext.Categories
                       on p.CategoryId equals c.Id 
                       where c.Id == id
                       select p).Count();
            if (find != null)
            {
                if (dem == 0)
                {
                    _dbContext.Categories.Remove(GetById(id));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposed)
        {
            if (!_disposed)
            {
                if (disposed)
                {
                    _dbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Lấy ra danh sách các danh mục trong db
        /// </summary>
        /// <returns>List các danh mục</returns>
        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

        /// <summary>
        /// Lấy ra 1 danh mục theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetById(int id)
        {
            Category cateFind = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (cateFind != null)
                return cateFind;
            else
                return null;
        }

        /// <summary>
        /// Lưu thay đổi vao db
        /// </summary>
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Sủa thông tin danh mục và cập nhật
        /// </summary>
        /// <param name="category"></param>
        /// <returns>bool</returns>
        public bool Update(Category category)
        {
            Category find = _dbContext.Categories.FirstOrDefault(category => category.Id == category.Id);
            if (find == null) return false;
            else
            {
                find.Name = category.Name;
                find.Description = category.Description;
                return true;
            }
        }
    }
}
