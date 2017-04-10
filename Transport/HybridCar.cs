using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Transport;

namespace Transport
{
    /// <summary>
    /// класс гибрид-машины
    /// </summary>
    [Serializable]
    public class HybridCar : ITransport
    {
        
        /// <summary>
        /// Пробег машины-гибрида
        /// </summary>
        private int _distance;
        /// <summary>
        /// Имя гибрид-машины
        /// </summary
        private string _transportName = "Hybrid";
        /// <summary>
        /// Расход электричества на 100 км
        /// </summary>
        private int _electricityConsumption;
        /// <summary>
        /// Текущее количество топлива 
        /// </summary>
        private double _theCurrentAmountOfFuel;
        /// <summary>
        /// Мощность аккумулятора 
        /// </summary>
        private int _powerOfBattery;
       
        /// <summary>
        /// Пробег машины-гибрида
        /// </summary>
        public int Distance
        {
            get { return _distance; }

            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Неверно задан пробег у гибрид машины");
                _distance = value;
            }
        }
        /// <summary>
        /// Имя модели
        /// </summary>
        public string TransportName
        {
            get { return _transportName; }

            set { _transportName = value; }
        }

        /// <summary>
        /// Расход электричества на 100 км
        /// </summary>
        int ElectricityConsumption
        {
            get { return _electricityConsumption; }

            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Неверно задан расход электричества у гибрид-машины");
                _electricityConsumption = value;
            }
        }
        /// <summary>
        /// Текущее количество  эл-ва
        /// </summary>
        public int CurrentAmountOfElectricity
        { get; set; }

         /// <summary>
        ///  Количество топлива
        /// </summary>
        public double TheCurrentAmountOfFuel
        {
            get { return _theCurrentAmountOfFuel; }

            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Неверно задано текущее количество топлива");
                _theCurrentAmountOfFuel = value;
            }
        }
        /// <summary>
        /// Мощность аккумулятора 
        /// </summary>
        public int PowerOfBattery
        {
            get { return _powerOfBattery; }
            set
            {
                if (value < 20||value>100)
                    throw new InvalidOperationException("Мощность аккумулятора должна быть не больше 100 и не меньше 20");
                _powerOfBattery = value;

            }
            
        }
        /// <summary>
        /// Расчет расхода топлива
        /// </summary>
        public double FuelCosts
        {
            get
            {
                return IsCanTravelDistance();
            }
            set { }
        }

        /// <summary>
        /// Метод расчета расхода топлива
        /// </summary>
        /// <returns>Расход </returns>
        public double IsCanTravelDistance()
        {
            if (_theCurrentAmountOfFuel*PowerOfBattery >= _distance)
            {
                return CurrentAmountOfElectricity * 100 / _distance;
            }
      
            return(CurrentAmountOfElectricity * 100 / 644) + (TheCurrentAmountOfFuel * 100 / (_distance - 644));
        }
    }
}




















/*if (distance <= 644) // Запас хода на эл-ве 644км
   {
       return CurrentAmountOfElectricity * 100 / distance;
   }
   // 644 км на эл-ве , а остальное на бензине
   return (CurrentAmountOfElectricity * 100 / 644) + (TheCurrentAmountOfFuel * 100 / (distance - 644));*/
