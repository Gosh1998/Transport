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
        /// <summary>
        /// кол-во топлива
        /// </summary>
        private double _fuelCount;
        /// <summary>
        ///Расход на 100 км
        /// </summary>
        private int _fuelConsumption;
        /// <summary>
        /// Текущее кол-во топлива у машины
        /// </summary>
        private int _theCurrentAmountOfFuel;

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
        /// кол-во топлива
        /// </summary>
       /* public double FuelCount
        {
            get { return _fuelCount; }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Неверно задан  количество топлива у машины");
                _fuelCount = value;
            }
        }*/

        /// <summary>
        /// Расход на 100 км
        /// </summary>
      /*  public int FuelConsumption
        {
            get { return _fuelConsumption; }
            set
            {
                if (value < 100)
                    throw new InvalidOperationException("Неверно задан расход топлива у машины за 100 км");
                _fuelConsumption = value;
            }
        }*/
        /// <summary> 
        /// Количество топлива у машины
        /// </summary>
        public int TheCurrentAmountOfFuel
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
            set
            {

            }

    
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