using KanatStore.DAL.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanatStore.Models
{
    [Table("Sản phẩm")]
    public class ProductViewModel
    {
        public List<ProductDetail> ProductDetails { get; set; }

        public List<Category> Categories { get; set; }
    }
}
