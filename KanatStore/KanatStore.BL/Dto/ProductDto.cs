﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace KanatStore.BLL.Dto
{
    public class ProductDto
    {
        public ProductDto() {
        }
        [Key]
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
        public string Origin { get ; set; } = String.Empty;
        [DisplayName("Hình ảnh")]
        public string Image { get; set; } = string.Empty;
        [DisplayName("Giá bán")]
        public double? Price { get; set; }
        [DisplayName("Giá nhập")]
        public double? ImportPrice { get; set; }
        [DisplayName("Số lượng có")]
        public int Quantity { get; set; }
        [DisplayName("Đơn vị")]
        public string Unit { get; set; } = string.Empty;
        [DisplayName("Trạng thái")]
        [Required(ErrorMessage ="Trạng thái không được bỏ trống")]
        public string Status { get; set; }
        [DisplayName("Mô tả")]
        [StringLength(200, ErrorMessage =("Mô tả không được vượt quá 200 kí tự"))]
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        [DisplayName("Danh mục")]
        public string CategoryName { get; set; } = string.Empty;
    }
}
