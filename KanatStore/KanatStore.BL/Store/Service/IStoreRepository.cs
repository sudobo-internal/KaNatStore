using KanatStore.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Store.Service
{
    /// <summary>
    /// Interface chứa phương thức quản lý thông tin cửa hàng
    /// </summary>
    public interface IStoreRepository:CommonRepository
    {
        /// <summary>
        /// Phương thức lấy ra toàn bộ cửa hàng
        /// </summary>
        /// <returns>List store</returns>
        public List<StoreDto> GetAll();
        /// <summary>
        /// Phương thức lấy ra cửa hàng theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Store</returns>
        public StoreDto Get(int id);
        /// <summary>
        /// tạo mới cửa hàng
        /// </summary>
        /// <param name="store"></param>
        public void Create(StoreDto store);
        /// <summary>
        /// Phương thức cập nhật thông tin cửa hàng
        /// </summary>
        /// <param name="store">cửa hàng muốn sửa</param>
        /// <returns>true/false</returns>
        public bool Update(StoreDto store);
        /// <summary>
        /// Xóa cửa hàng
        /// </summary>
        /// <param name="id">id của cửa hàng muốn xóa</param>
        /// <returns>true/false</returns>
        public bool Delete(int id);

    }
}
