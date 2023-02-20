using System.ComponentModel.DataAnnotations.Schema;

namespace KanatStore.DAL.Entities
{
    /// <summary>
    /// Description of Employee.
    /// </summary>
    [Table("Nhân viên")]
    public class Employee:Personal
    {
        public Employee() 
        {
            Type = "Employee";
        }
        /// <summary>
        /// Căn cước công dân
        /// </summary>
        [Column("CCCD", Order = 7, TypeName = "nvarchar(50)")]        
        public string Identification { get; set; }
        [Column("Số ngày làm", Order = 8, TypeName = "float")]        
        public float WorkDays { get; set; }
        [Column("Thưởng", Order = 9, TypeName = "decimal")]        
        public decimal Bonus { get; set; }
        /// <summary>
        /// hệ số lương
        /// </summary>
        [Column("Hệ số lương", Order = 10, TypeName = "decimal")]        
        public decimal Coefficient { get;set; }
        private decimal _salary;
        [Column("Tổng lương", Order = 11, TypeName = "decimal")]
        public decimal Salary {
            get => _salary;
            set
            {
                _salary = (decimal)WorkDays * Coefficient + Bonus;
            }
        }
        [Column("Ảnh", Order = 12, TypeName = "nvarchar(200)")]
        public string Image { get; set; }
    }
}
