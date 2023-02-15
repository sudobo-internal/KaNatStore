using KanatStore.BLL.Dto;

namespace KanatStore.UI.Models
{
    /// <summary>
    /// lớp ProductDetailViewModel chứa trường dữ liệu ProductDetail    
    /// </summary>
    public class ProductDetailViewModel
    {
        public ProductDetailViewModel() {
            ProductDetail = new ProductDto();
        }
        /// <summary>
        /// trường dữ liệu ProductDetail có kiểu dữ kiệu là ProductDto
        /// </summary>
        public ProductDto ProductDetail { get; set; }
    }
}
