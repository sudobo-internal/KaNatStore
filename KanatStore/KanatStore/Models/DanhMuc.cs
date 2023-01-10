using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KanatStore.Models
{
    public class DanhMuc
    {
        public DanhMuc()
        {
            Products = new List<Product>();
        }
        [Key]
        public int MaDM { get; set; }
        [Required]
        [DisplayName("Tên danh mục")]
        public string TenDM { get; set; }
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
        public virtual ICollection<Product> Products { set; get; }
    }
}
