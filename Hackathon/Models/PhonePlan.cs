using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models.PlanParameters
{
    public class PhonePlan //Тариф
    {
        /// <summary>
        /// Исходящие звонки на номера МОТИВ
        /// </summary>
        private double OnMotiv { get; set; }

        /// <summary>
        /// Исходящие звонки на номера региона подключения других операторов
        /// </summary>
        private double OnOtherOp { get; set; }

        /// <summary>
        /// Исходящие звонки на номера региона подключения ГТС
        /// </summary>
        private double OnGTC { get; set; }

        /// <summary>
        /// Исходящие звонки на номера РФ
        /// </summary>
        private double OnRF { get; set; }

        /// <summary>
        /// Исходящие звонки международного соединения
        /// </summary>
        private double OnInternational { get; set; }

        /// <summary>
        /// Мобильный интернет
        /// </summary>
        private double MobileInternet { get; set; }

        /// <summary>
        /// Исходящие SMS-сообщения на номера РФ
        /// </summary>
        private double SmsOnRF { get; set; }

        /// <summary>
        /// Исходящие SMS-сообщения на номера международных операторов
        /// </summary>
        private double SmsOnInternational { get; set; }

        /// <summary>
        /// Исходящие MMS-сообщения на номера РФ
        /// </summary>
        private double MmsOnRF { get; set; }

        /// <summary>
        /// Входящие в национальном роуминге
        /// </summary>
        private double IncomingNatRoaming { get; set; }


        /// <summary>
        /// Тариф
        /// </summary>
        /// <param name="onMotiv">Исходящие звонки на номера МОТИВ</param>
        /// <param name="onOtherOp">Исходящие звонки на номера региона подключения других операторов</param>
        /// <param name="onGTC">Исходящие звонки на номера региона подключения ГТС</param>
        /// <param name="onRF">Исходящие звонки на номера РФ</param>
        /// <param name="onInternational">Исходящие звонки международного соединения</param>
        /// <param name="mobileInternet">Мобильный интернет</param>
        /// <param name="smsOnRF">Исходящие SMS-сообщения на номера РФ</param>
        /// <param name="smsOnInternational">Исходящие SMS-сообщения на номера международных операторов</param>
        /// <param name="mmsOnRF">Исходящие MMS-сообщения на номера РФ</param>
        /// <param name="incomingNatRoaming">Входящие в национальном роуминге </param>
        PhonePlan(double onMotiv, double onOtherOp, double onGTC, double onRF, double onInternational,
        double mobileInternet, double smsOnRF, double smsOnInternational, double mmsOnRF,
        double incomingNatRoaming)
        {
            OnMotiv = onMotiv;
            OnOtherOp = onOtherOp;
            OnGTC = onGTC;
            OnRF = onRF;
            OnInternational = onInternational;
            MobileInternet = mobileInternet;
            SmsOnRF = smsOnRF;
            SmsOnInternational = smsOnInternational;
            MmsOnRF = mmsOnRF;
            IncomingNatRoaming = incomingNatRoaming;
        }

    }
}