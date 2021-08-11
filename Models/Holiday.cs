using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Models
{
    public class Holiday
    {
        public string HolidayID { get; set; }
        public string Holidaydate { get; set; }
        public string HolidaylocalName { get; set; }
        public string Holidayname { get; set; }
        public string HolidaycountryCode { get; set; }
        public bool Holidayfixed { get; set; }
        public bool Holidayglobal { get; set; }
        public string Holidaycounties { get; set; }
        public int HolidaylaunchYear { get; set; }
        public string Holidaytype { get; set; }
    }

}
