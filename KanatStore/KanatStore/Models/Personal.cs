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
        public string FullName { set; get; }
        [DisplayName("Ngày sinh")]
        public DateTime DateOfBirth { set; get; }
        [DisplayName("Giới tính")]
        public string Sex { set; get; }
        [Required]
        [StringLength(11)]
        [DisplayName("SĐT")]
        public string PhoneNumber { set; get; }
        [Required]
        public string Type { set; get; }
    }
}
