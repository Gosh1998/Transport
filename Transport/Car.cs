using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;

namespace Transport
{
    /// <summary>
    /// класс машины
    /// </summary>
    [Serializable]
    public class Car : ITransport
    {
   
        /// <summary>
        /// Пробег машины
        /// </summary>
        private int _distance;
        /// <summary>
        /// Имя машины
        /// </summary>
        private string _transportName = "car";

        private double _theCurrentAmountOfFuel;

        /// <summary>
        /// Пробег машины
        /// </summary>
        public int Distance
        {
            get { return _distance; }

            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Неверно задан пробег траспорта");
                _distance = value;
            }
        }
        /// <summary>
        /// Имя машины
        /// </summary>
        public string TransportName
        {
            get { return _transportName; }

            set { _transportName = value; }
        }
      
        /// <summary> 
        /// Количество топлива у машины
        /// </summary>
        public double TheCurrentAmountOfFuel
        {
            get { return _theCurrentAmountOfFuel; }
            set
            {
                if (value < 0 || value > 1500)
                    throw new InvalidOperationException("Неверно задана текущее кол-во топливо у машины");
                _theCurrentAmountOfFuel = value;
            }
        }

        /// <summary>
        /// метод расчета расхода топлива
        /// </summary>
        /// <returns>расход топлива </returns>
        public double IsCanTravelDistance()
        {
            return TheCurrentAmountOfFuel * 100 / _distance;
        }
        /// <summary>
        /// расчет расход топлива
        /// </summary>
        public double FuelCosts
        {
            get
            {
                return IsCanTravelDistance();
            }
            set { }
        }
    }
}


















/*public bool IsCanTravelDistance(int distance)
{ if(TheCurrentAmountFuel*FuelCount<distance)
    {
    return false
    }
    return true;
}*/