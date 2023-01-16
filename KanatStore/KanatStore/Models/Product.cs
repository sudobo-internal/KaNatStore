using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanatStore.Models
{
    [Table("Sản phẩm")]
    public class Product
    {
        [Key]
        public int Id { set; get; }
        [Required]
        [StringLength(50)]
        [DisplayName("Tên sản phẩm")]
        public string Name { set; get; }
        [DisplayName("Chiều dài")]
        public float Length { set; get; }
        [DisplayName("Chiều rộng")]
        public float Width { set; get; }
        [DisplayName("Chiều dày")]
        public float Thickness { set; get; }
        [DisplayName("Xuất xứ")]
        public string Origin { set; get; }
        [DisplayName("Hình ảnh")]
        public string Image { set; get; }
        [DisplayName("Giá bán")]
        public double Price { set; get; }
        [DisplayName("Giá nhập")]
        public double ImportPrice { set; get; }
        [DisplayName("Số lượng có")]
        public int Quantity { set; get; }
        [DisplayName("Đơn vị")]
        public string Unit { set; get; }
        [DisplayName("Trạng thái")]
        public string? Status { set; get; }
        [DisplayName("Mô tả")]
        public string? Description { set; get; }
        public virtual Category Category { set; get; }
    }
}
