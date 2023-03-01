using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.DAL.Entities
{
    public class TimeSheet
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime CreatAt { get; set; }
        public double Total(DateTime checkIn, DateTime checkOut)
        {
            return checkOut.Hour - checkIn.Hour - 1.5;
        }
        public TimeSheet() 
        {
            
        }
    }
}
