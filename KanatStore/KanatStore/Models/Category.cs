using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KanatStore.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<ProductViewModel>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Tên danh mục")]
        public string Name { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        public virtual ICollection<ProductViewModel> Products { set; get; }
    }
}
