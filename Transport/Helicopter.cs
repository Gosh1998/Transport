using System;

namespace Transport
{/// <summary>
 /// класс вертолета
 /// </summary>
    [Serializable]
    public class Helicopter : ITransport

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
        private uint _speed;
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
                    throw new InvalidOperationException("Неверно задан расход топлива у вертолета(за час)");
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
                if (value < 100)
                    throw new InvalidOperationException("Неверно задан расход топлива у вертолета");
                _fuelConsumption = value;
            }
        }
        /// <summary>
        /// Пробег
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
        /// Имя транспорта
        /// </summary>
        public string TransportName
        {
            get { return _transportName; }

            set { _transportName = value; }
        }
        /// <summary>
        /// Скорость вертолета
        /// </summary>
        public uint Speed
        {
            get { return _speed; }
            set
            {
                if (value  > 380)
                    throw new InvalidOperationException("Неверно задан скорость вертолета");
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
                    throw new InvalidOperationException("Неверный объем бака");
                _volumeOfTheHelicopter = value;
            }
        }
        /// <summary>
        /// метод расчета расхода топлива
        /// </summary>
        /// <returns>расход топлива </returns>
        public double IsCanTravelDistance()
        {
            if (_fuelConsumption*_volumeOfTheHelicopter > _distance)
            {
                
            }
            return  FuelConsumption*100/_distance  ;
        }
        /// <summary>
        /// расчет расхода топлива
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
{ if(_fuelConsumption*_volumeOfTheHelicopter > distance)
    {
    return false
    }
   return true ;
}*/
