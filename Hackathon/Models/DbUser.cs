using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hackathon.Models.PlanParameters;

namespace Hackathon.Models
{
    public class DbUser
    {
        public virtual Collection<Transaction> Transactions { get; set; }
        public virtual Collection<DbService> Services { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float Balance { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime BirthDate { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
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
        public int PlanCode { get; set; }
        [ForeignKey("PlanCode")]
        public PhonePlan Plan { get; set; }
        public DateTime PlanConectionDate { get; set; }
        public int MinutesLeft { get; set; }
        public float GbLeft { get; set; }
        public int SMSLeft {get; set;}
        //public string PlanName { get; set; }
        //[ForeignKey("PlanCode")]
        //public PhonePlan Plan { get; set; }
        public override string ToString()
        {
            return Name + " " + MiddleName + " " + SecondName;
        }
    }
}