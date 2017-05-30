using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport;

namespace Transport
{
    [Serializable]
    public abstract class  TransportBase : ITransport
    {
        /// <summary>
        /// Пробег
        /// </summary>
        private int _distance;


        /// <summary>
        /// Расчет расхода топлива
        /// </summary>
        public abstract double FuelCosts
        { get; set; }

        /// <summary>
        /// Метод расчета топлива
        /// </summary>
        public abstract double IsCanTravelDistance();
        

        /// <summary>
        /// Пробег
        /// </summary>
        public int Distance
        {
            get { return _distance; }

            set { _distance = DistanceChecker.DistanceValue(value); }
        }

        /// <summary>
        /// Имя транспорта
        /// </summary>
        public abstract string TransportName { get; set; }
    }
}
