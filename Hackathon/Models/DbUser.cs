using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class DbUser
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime BirthDate { get; set; }
        public double Age 
        { 
            get
            {
                var today = DateTime.Today;
                var age = BirthDate.Year - today.Year;
                if (today.Date.Month < BirthDate.Month)
                    return age - 1;
                else if (today.Date.Month == BirthDate.Month)
                    return today.Date.Day < BirthDate.Day ? age - 1 : age;
                else
                    return age;
            }
        }
        public string PhoneNumber { get; set; } //основной номер
        public string ExtraPhoneNumber { get; set; } //дополнительный номер
        public string Email { get; set; }
        public string Region { get; set; }
        //public Тариф ...
        public override string ToString()
        {
            return Name + " " +  MiddleName + " " + SecondName;
        }
    }
}