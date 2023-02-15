using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Categories.Services
{
    /// <summary>
    /// Interface định nghĩa phương thức quản lý danh mục
    /// </summary>
    public interface ICategoryRespository:CommonRepository
    {
        /// <summary>
        /// Hiển thị danh sách danh mục
        /// </summary>
        /// <returns>List category</returns>
        public List<Category> GetAll();
        /// <summary>
        /// Tìm danh mục theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Category</returns>
        public Category GetById(int id);
        /// <summary>
        /// Tạo mới danh mục
        /// </summary>
        /// <param name="category"></param>
        public void Create(Category category);
        /// <summary>
        /// Sửa danh mục
        /// </summary>
        /// <param name="category"></param>
        /// <returns>true/false</returns>
        public bool Update(Category category);
        /// <summary>
        /// Xóa danh mục 
        /// </summary>
        /// <param name="id">tham số truyền vào là id của danh mục muốn xóa</param>
        /// <returns>true/false</returns>
        public bool Delete(int id);
    }
}
