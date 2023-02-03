using KanatStore.BLL.Dto;
using KanatStore.DAL.Entities;

namespace KanatStore.UI.Models
{
    public class ProductViewModel
    {
        public ProductViewModel() {
            Products = new List<ProductDto>();
            Categories = new List<Category>();
        }
        public List<ProductDto> Products { get; set; }
        //public ProductDto productDetail { get; set; }
        public List<Category> Categories { get; set; }
    }
}
