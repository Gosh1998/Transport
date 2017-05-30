using System;

namespace Transport
{/// <summary>
 /// класс вертолета
 /// </summary>
    [Serializable]
    public class Helicopter : TransportBase
    {
       
        /// <summary>
        /// Расход топлива у вертолета за час
        /// </summary>
        private double _fuelConsumptionPerHour;
        /// <summary>
        /// Расход топлива у вертолета на 100 км
        /// </summary>
        private double _fuelConsumption;
        /// <summary>
        /// Пробег
        /// </summary>
        private int _distance;
        /// <summary>
        /// Имя транспорта
        /// </summary>
        private string _transportName = "Helicopter";
        /// <summary>
        /// Скорость вертолета
        /// </summary>
        private int _speed;
        /// <summary>
        /// Объем бака у вертолета
        /// </summary>
        private int _volumeOfTheHelicopter;
   

        /// <summary>
        ///  Расход топлива у вертолета за час  
        /// </summary>
        public double FuelConsumptionPerHour
        {
            get { return _fuelConsumptionPerHour; }
            set
            {
                if (value < 380)
                    throw new ArgumentException("Расход топлива у вертолета должен быть больше 380");
                _fuelConsumptionPerHour = value;
            }
        }
        /// <summary>
        /// у ветолета расход больше 100 л        
        /// </summary>
        public double FuelConsumption
        {
            get { return _fuelConsumption; }
            set
            {
                if (value <= 100)
                    throw new ArgumentException("Неверно задан расход топлива у вертолета(больше 100)");
                _fuelConsumption = value;
            }
        }

        /// <summary>
        /// Имя транспорта
        /// </summary>
        public override string TransportName
        {
            get { return _transportName; }

            set { _transportName = value; }
        }
        /// <summary>
        /// Скорость вертолета
        /// </summary>
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value  > 380 || value==0)
                    throw new ArgumentException("Неверно задан скорость вертолета");
                _speed = value;
            }
        }
        /// <summary>
        /// Объем бака 
        /// </summary>
        public int VolumeOfTheTank
        {
            get
            {
                return _volumeOfTheHelicopter;
            }

            set
            {
                if (value <= 0 || value >= 200)
                    throw new ArgumentException("Объем бака не должен превышать 200 л");
                _volumeOfTheHelicopter = value;
            }
        }
        /// <summary>
        /// метод расчета расхода топлива
        /// </summary>
        /// <returns>расход топлива </returns>
        public override double IsCanTravelDistance()
        {
            if (_fuelConsumption*_volumeOfTheHelicopter > Distance)
            {
                
            }
            return  FuelConsumption*100/Distance  ;
        }
        /// <summary>
        /// расчет расхода топлива
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
{ if(_fuelConsumption*_volumeOfTheHelicopter > distance)
    {
    return false
    }
   return true ;
}*/
