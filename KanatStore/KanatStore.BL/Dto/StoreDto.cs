using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Dto
{
    public class StoreDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên cửa hàng không được để trống")]
        [DisplayName("Tên cửa hàng")]
        public string Name { get; set; }
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ cửa hàng không được để trống")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DisplayName("Số điện thoại")]
        [RegularExpression(@"[0-9]{1,12}", ErrorMessage ="Số điện thoại chỉ chứa kí tự số")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage ="Vui lòng nhập đúng định dạng địa chỉ email")]
        [DisplayName("Email")]
        public string Email { get; set; }
    }

}
