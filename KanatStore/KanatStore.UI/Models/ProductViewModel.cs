using KanatStore.BLL.Dto;
using KanatStore.DAL.Entities;

namespace KanatStore.UI.Models
{
    /// <summary>
    /// class chứa list products và list Categories
    /// </summary>
    public class ProductViewModel
    {
        public ProductViewModel() {
            Products = new List<ProductDto>();
            Categories = new List<Category>();
        }
        /// <summary>
        /// có kiểu dữ liệu là List<ProductDto>
        /// </summary>
        public List<ProductDto> Products { get; set; }
        /// <summary>
        /// có kiểu dữ liệu là List<Category>
        /// </summary>
        public List<Category> Categories { get; set; }
    }
}
