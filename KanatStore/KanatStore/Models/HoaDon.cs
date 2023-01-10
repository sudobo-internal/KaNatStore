using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KanatStore.Models
{
    public class HoaDon
    {
        [Key]
        public string SoHD { get; set; }
        [Required]
        [DisplayName("Ngày tháng")]
        public DateTime NgayXuat { get; set; }
        [DisplayName("Trạng thái")]
        public string TrangThai { get; set; }
        public HoaDon() { 
        }
    }
}
