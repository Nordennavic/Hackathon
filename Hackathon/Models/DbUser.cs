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
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.Length == 10 && int.TryParse(value, out int number))
                {
                    phoneNumber = "+7 (";
                    string addition = "";
                    for (var i = 0; i < 10; i++)
                    {
                        if (i < 3 || i > 3 && i < 6 || i > 6 && i < 8 || i > 8)
                            addition = value[i].ToString();
                        else if (i == 3)
                            addition = ") ";
                        else if (i == 6)
                            addition = "-";
                        else if (i == 8)
                            addition = "-";

                        phoneNumber += addition;
                    }  
                }
            }
        }

    }
}
