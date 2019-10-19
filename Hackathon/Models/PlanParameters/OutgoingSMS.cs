using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models.PlanParameters
{
    public class OutgoingSMS
    {
        private Types CurrentType;  // Пакет SMS
        private double Value; // Количество SMS или за рублей в зависимости от пакета

        OutgoingSMS(bool type, int value)
        {
            //CurrentType = type;
            Value = value;
        }

        private enum Types // Типы пакетов SMS
        {
            fix = 0,        // Фиксированное кол-во cмс
            arbitrary = 1,  // ₽/SMS
        }
    }
}
