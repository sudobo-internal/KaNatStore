using KanatStore.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Product.Services
{
    /// <summary>
    /// interface chứa các phương thức quản lý product
    /// </summary>
    public interface IProductRespository:CommonRepository
    {
        /// <summary>
        /// Lấy ra danh sách sản phẩm
        /// </summary>
        /// <returns>List products</returns>
        public List<ProductDto> GetAll();
        /// <summary>
        /// Lấy ra sản phẩm theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        public ProductDto GetById(int id);
        /// <summary>
        /// Thêm sản phẩm mới
        /// </summary>
        /// <param name="pro"></param>
        public void Create(ProductDto pro);
        /// <summary>
        /// Phương thức sửa sản phẩm
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public bool Update(ProductDto pro);
        /// <summary>
        /// Phương thức xóa sản phấm
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id);

    }
}
