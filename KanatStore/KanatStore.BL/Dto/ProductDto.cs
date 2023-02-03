﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace KanatStore.BLL.Dto
{
    public class ProductDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Chiều dài")]
        public float Length { get; set; }
        [DisplayName("Chiều rộng")]
        public float Width { get; set; }
        [DisplayName("Chiều dày")]
        public float Thickness { get; set; }
        [DisplayName("Xuất xứ")]
        public string Origin { get; set; }
        [DisplayName("Hình ảnh")]
        public string? Image { get; set; }
        [DisplayName("Giá bán")]
        public double Price { get; set; }
        [DisplayName("Giá nhập")]
        public double ImportPrice { get; set; }
        [DisplayName("Số lượng có")]
        public int Quantity { get; set; }
        [DisplayName("Đơn vị")]
        public string? Unit { get; set; }
        [DisplayName("Trạng thái")]
        public string Status { get; set; }
        [DisplayName("Mô tả")]
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        [DisplayName("Danh mục")]
        public string? CategoryName { get; set; }
    }
}
