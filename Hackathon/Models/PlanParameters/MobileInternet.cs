using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Models.PlanParameters
{
    private (DataRate, int) Speed;
    private double Cost; // Стоимость за MB
    private int InternetPackage; //Ёмкость пакета в GB

    public class MobileInternet
    {
        MobileInternet(int dataRate, int speedValue, double cost)
        {
            Speed = (dataRate, speedValue);
            Cost = cost;
        }

        MobileInternet(int dataRate, int speedValue, int Cost, int package)
        {
           Speed = (dataRate, speedValue);
           Cost = cost;
            InternetPackage = package;
        }
    }
    enum DataRate
    {
        KB = 0,
        MB = 1
    }
}
