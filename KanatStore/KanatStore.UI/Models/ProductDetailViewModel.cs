using KanatStore.BLL.Dto;

namespace KanatStore.UI.Models
{
    public class ProductDetailViewModel
    {
        public ProductDetailViewModel() {
            ProductDetail = new ProductDto();
        }
        public ProductDto ProductDetail { get; set; }
    }
}
