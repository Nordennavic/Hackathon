using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models.PlanParameters
{
    public class PhonePlan //Тариф
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int AbonentPay { get; set; }
        public int PrimaryPay { get; set; }

        /// <summary>
        /// Название тарифа
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Исходящие звонки на номера МОТИВ | ₽/мин
        /// </summary>
        public double? OnMotiv { get; set; }

        /// <summary>
        /// Исходящие звонки на номера МОТИВ | Пакет
        /// </summary>
        public double? OnMotivFix { get; set; }

        /// <summary>
        /// Исходящие звонки на номера региона подключения других операторов
        /// </summary>
        public double OnOtherOp { get; set; }

        /// <summary>
        /// Исходящие звонки на номера региона подключения ГТС
        /// </summary>
        public double? OnGTC { get; set; }

        /// <summary>
        /// Исходящие звонки на номера РФ
        /// </summary>
        public double OnRF { get; set; }


        /// <summary>
        /// Мобильный интернет
        /// </summary>
        public double MobileInternet { get; set; }

        /// <summary>
        /// Исходящие SMS-сообщения на номера РФ | ₽/мин
        /// </summary>
        public double? SmsOnRF { get; set; }

        /// <summary>
        /// Исходящие SMS-сообщения на номера РФ | Пакет
        /// </summary>
        public double? SmsOnRFFix { get; set; }

        /// <summary>
        /// Исходящие MMS-сообщения на номера РФ
        /// </summary>
        public double MmsOnRF { get; set; }



        /// <summary>
        /// Тариф
        /// </summary>
        /// <param name="onMotiv">Исходящие звонки на номера МОТИВ | ₽/мин | Поставь null если пакетный план другой</param>
        /// <param name="onMotivFix">Исходящие звонки на номера МОТИВ | Пакет | Поставь null если пакетный план другой</param>
        /// <param name="onOtherOp">Исходящие звонки на номера региона подключения других операторов</param>
        /// <param name="onGTC">Исходящие звонки на номера региона подключения ГТС</param>
        /// <param name="onRF">Исходящие звонки на номера РФ</param>
        /// <param name="onInternational">Исходящие звонки международного соединения</param>
        /// <param name="mobileInternet">Мобильный интернет</param>
        /// <param name="smsOnRF">Исходящие SMS-сообщения на номера РФ | ₽/мин | Поставь null если пакетный план другой</param>
        /// <param name="smsOnRF">Исходящие SMS-сообщения на номера РФ | Пакет| Поставь null если пакетный план другой</param>
        /// <param name="smsOnInternational">Исходящие SMS-сообщения на номера международных операторов</param>
        /// <param name="mmsOnRF">Исходящие MMS-сообщения на номера РФ</param>
        /// <param name="incomingNatRoaming">Входящие в национальном роуминге </param>
        public PhonePlan(string title, double? onMotiv, double? onMotivFix, double onOtherOp, double? onGTC, double onRF,
        double mobileInternet, double? smsOnRF, double? smsOnRFFix, double mmsOnRF, int abonentPay, int primaryPay)
        {
            Title = title;
            OnMotiv = onMotiv;
            OnMotivFix = onMotivFix;
            OnOtherOp = onOtherOp;
            OnGTC = onGTC;
            OnRF = onRF;
            MobileInternet = mobileInternet;
            SmsOnRF = smsOnRF;
            SmsOnRFFix = smsOnRFFix;
            MmsOnRF = mmsOnRF;
            AbonentPay = abonentPay;
            PrimaryPay = primaryPay;
        }

    }
}