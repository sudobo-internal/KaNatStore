using KanatStore.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Dto
{
    public class EmployeeDto 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Identification { get; set; }
        public float WorkDays { get; set; }
        public decimal Bonus { get; set; }
        public decimal Coefficient { get; set; }
        public string Image { get; set; }
    }
}
