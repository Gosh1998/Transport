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
    public class HybridCar : TransportBase
    {

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
        /// Текущее количество топлива 
        /// </summary>
        private int _currentAmountOfElectricity;
        /// <summary>
        /// Мощность аккумулятора 
        /// </summary>
        private int _powerOfBattery;
       
        /// <summary>
        /// Имя модели
        /// </summary>
        public override string TransportName
        {
            get { return _transportName; }

            set { _transportName = value; }
        }

        /// <summary>
        /// Расход электричества на 100 км
        /// </summary>
        public int ElectricityConsumption
        {
            get { return _electricityConsumption; }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Неверно задан расход электричества у гибрид-машины");
                _electricityConsumption = value;
            }
        }

        /// <summary>
        /// Текущее количество  эл-ва
        /// </summary>
        public int CurrentAmountOfElectricity
        {
            get { return _currentAmountOfElectricity; }

            set
            {
                if (value < 0 || value > 20000)
                    throw new ArgumentException("Неверно заданое кол-во эл-ва");
                _currentAmountOfElectricity = value;
            }
        }

        /// <summary>
        ///  Количество топлива
        /// </summary>
        public double TheCurrentAmountOfFuel
        {
            get { return _theCurrentAmountOfFuel; }

            set
            {
                if (value < 0||value>1000)
                    throw new ArgumentException("Неверно задано текущее количество топлива");
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
                if (value < 20 || value>100)
                    throw new ArgumentException("Мощность аккумулятора должна быть не больше 100 и не меньше 20");
                _powerOfBattery = value;
            }  
        }

        /// <summary>
        /// Метод расчета расхода топлива
        /// </summary>

        /// <returns>Расход </returns>
        public override double IsCanTravelDistance()
        {
            if (Distance <= 400) // Запас хода на эл-ве 400км
            {
                return CurrentAmountOfElectricity * 100 / Distance;
            }
            // 400 км на эл-ве, остальное на бензине
            return (CurrentAmountOfElectricity * 100 / 400) + (TheCurrentAmountOfFuel * 100 / (Distance - 400));
        }
        /// <summary>
        /// Расчет расхода топлива
        /// </summary>
        public override double FuelCosts
        {
            get { return IsCanTravelDistance(); }

            set { }
        }
    }
}




















/*if (distance <= 644) // Запас хода на эл-ве 644км
   {
       return CurrentAmountOfElectricity * 100 / distance;
   }
   // 644 км на эл-ве , а остальное на бензине
   return (CurrentAmountOfElectricity * 100 / 644) + (TheCurrentAmountOfFuel * 100 / (distance - 644));*/
