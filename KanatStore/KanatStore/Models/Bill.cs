using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KanatStore.Models
{
    public class Bill
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [DisplayName("Ngày tháng")]
        public DateTime DayCreate { get; set; }
        [DisplayName("Trạng thái")]
        public string Status { get; set; }
        public Bill() { 
        }
    }
}
