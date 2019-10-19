using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class DbUser
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirhtDate { get; set; }
        public double Age 
        { 
            get
            {
                var today = DateTime.Today;
                var age = BirhtDate.Year - today.Year;
                if (today.Date.Month < BirhtDate.Month)
                    return age - 1;
                else if (today.Date.Month == BirhtDate.Month)
                    return today.Date.Day < BirhtDate.Day ? age - 1 : age;
                else
                    return age;
            }
        }
        public string PhoneNumber { get; set; } //основной номер
        public string ExtraPhoneNumber { get; set; } //дополнительный номер
        public string Email { get; set; }
        public string Region { get; set; }
        //public Тариф ...

    }
}
