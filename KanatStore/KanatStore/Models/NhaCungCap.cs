using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KanatStore.Models
{
    public class NhaCungCap
    {
        [Key]
        public int MaNCC { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Tên NCC")]
        public string TenNCC { get; set; }
        [Required]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }
        [Required]
        [DisplayName("SĐT")]
        public string SDT { get; set; }
    }
}
