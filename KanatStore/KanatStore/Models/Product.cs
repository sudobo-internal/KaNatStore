using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanatStore.Models
{
    [Table("Sản phẩm")]
    public class Product
    {
        [Key]
        public int MaSP { set; get; }
        [Required]
        [StringLength(50)]
        [DisplayName("Tên sản phẩm")]
        public string TenSP { set; get; }
        [DisplayName("Chiều dài")]
        public float ChieuDai { set; get; }
        [DisplayName("Chiều rộng")]
        public float ChieuRong { set; get; }
        [DisplayName("Chiều dày")]
        public float ChieuDay { set; get; }
        [DisplayName("Xuất xứ")]
        public string XuatXu { set; get; }
        [DisplayName("Hình ảnh")]
        public string HinhAnh { set; get; }
        [DisplayName("Giá bán")]
        public double GiaBan { set; get; }
        [DisplayName("Giá nhập")]
        public double GiaNhap { set; get; }
        [DisplayName("Số lượng có")]
        public int SoLuongCo { set; get; }
        [DisplayName("Đơn vị")]
        public string DonViTinh { set; get; }
        [DisplayName("Trạng thái")]
        public string? TrangThai { set; get; }
        [DisplayName("Mô tả")]
        public string? MoTa { set; get; }
        public virtual DanhMuc DanhMuc { set; get; }
    }
}
