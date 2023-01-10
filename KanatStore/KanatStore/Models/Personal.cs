using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KanatStore.Models
{
    public class Personal
    {
        [Key]
        public int Id { set; get; }
        [StringLength(100)]
        [Required]
        [DisplayName("Họ tên")]
        public string HoTen { set; get; }
        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { set; get; }
        [DisplayName("Giới tính")]
        public string GioiTinh { set; get; }
        [Required]
        [StringLength(11)]
        [DisplayName("SĐT")]
        public string SDT { set; get; }
        [Required]
        public string Type { set; get; }
    }
}
