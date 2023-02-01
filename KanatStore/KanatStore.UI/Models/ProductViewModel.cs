using KanatStore.DAL.Entities;

namespace KanatStore.UI.Models
{
    public class ProductViewModel
    {
        public List<ProductDetail> products { get; set; }
        public ProductDetail productDetail { get; set; }
        public List<Category> categories { get; set; }
    }
}
