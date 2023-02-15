using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanatStore.BLL.Dto
{
    /// <summary>
    /// class ProductDto
    /// </summary>
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên sản phẩm không được bỏ trống")]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Chiều dài")]
        [Required(ErrorMessage = "Chiều dài không được bỏ trống")]
        public float Length { get; set; }
        [Required(ErrorMessage = "Chiều rộng không được bỏ trống")]
        [DisplayName("Chiều rộng")]
        public float Width { get; set; }
        [DisplayName("Chiều dày")]
        public float? Thickness { get; set; }
        [DisplayName("Xuất xứ")]
        public string Origin { get; set; }
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }
        [DisplayName("Giá bán")]
        public double? Price { get; set; }
        [DisplayName("Giá nhập")]
        public double? ImportPrice { get; set; }
        [DisplayName("Số lượng có")]
        public int Quantity { get; set; }
        [DisplayName("Đơn vị")]
        public string Unit { get; set; }
        [DisplayName("Trạng thái")]
        [Required(ErrorMessage ="Trạng thái không được bỏ trống")]
        public string Status { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [DisplayName("Danh mục")]
        public string CategoryName { get; set; }
    }
}
