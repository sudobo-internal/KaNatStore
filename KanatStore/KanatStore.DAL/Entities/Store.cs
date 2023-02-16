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
    /// lớp Store chứa thông tin của cửa hàng
    /// </summary>
    [Table("StoreInformation")]
    public class Store
    {
        public Store() { }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Name", TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        [Column("Address", TypeName = "nvarchar(50)")]
        public string Address { get; set; }
        [Column("PhoneNumber", TypeName = "nvarchar(11)")]
        public string PhoneNumber { get; set; }
        [Column("Email", TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        
    }
}
