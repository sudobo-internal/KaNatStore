using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.DAL.Entities
{
    /// <summary>
    /// lớp cơ sở cho nhân viên, nhà cung cấp, khách hàng
    /// </summary>
    public class Personal
    {
        [Key]
        [Column("Id", Order =0)]
        public int Id { get; set; }
        [Column("Họ và tên", Order =1, TypeName ="nvarchar(50)")]
        public string FullName { get; set; }
        [Column("Ngày sinh", Order = 2, TypeName ="DateTime")]
        public DateTime DOB { get; set; }
        [Column("Giới tính", Order = 3, TypeName ="nvarchar(10)")]
        public string Gender { get; set; }
        [Column("Địa chỉ", Order = 4, TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        [Column("Số điện thoại", Order = 5, TypeName = "nvarchar(12)")]
        public string ContactNumber { get; set; }
        [Column("Loại đối tượng", Order = 6, TypeName = "nvarchar(50)")]
        public string Type { get; set; }
    }
}
