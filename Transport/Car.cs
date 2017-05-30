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
    public class Car : TransportBase
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
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="theCurrent"></param>
        public Car(int distance,double theCurrent)
        {
            Distance = DistanceChecker.DistanceValue(distance);
            TheCurrentAmountOfFuel = theCurrent;
        }
        
        public Car()
        {
            
        }

        /// <summary>
        /// Имя машины
        /// </summary>
        public override string TransportName
        {
            get { return _transportName; }

            set{ _transportName = value; }
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
                    throw new ArgumentException("Неверно задана текущее кол-во топливо у машины");
                _theCurrentAmountOfFuel = value;
            }
        }

        /// <summary>
        /// метод расчета расхода топлива
        /// </summary>
        /// <returns>расход топлива </returns>
        public override double IsCanTravelDistance()
        {
            return TheCurrentAmountOfFuel * 100 / Distance;
        }
        /// <summary>
        /// расчет расход топлива
        /// </summary>
        public override double FuelCosts
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