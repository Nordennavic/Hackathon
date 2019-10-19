using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models.PlanParameters
{
    public class OutgoingCall
    {         
        private Types CurrentType;  // Пакет минут 
        private double Value; // Количество минут/рублей в зависимости от пакета

        OutgoingCall(bool type, int value) 
        {
            CurrentType = type; 
            Value = value;
        }

        private enum Types // Типы пакета минут
        {
            fix = 0,        // Фиксированное кол-во минут 
            arbitrary = 1,  // ₽/мин
        }
    }
}
