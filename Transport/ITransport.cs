using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    /// <summary>
    ///Интерфейс транспорт!
    /// </summary>
    public interface ITransport
    {
        /// <summary>
        /// Расход топлива
        /// </summary>
        double FuelCosts { get; set; }
        /// <summary>
        /// Название транспорта
        /// </summary>
        string TransportName { get; set; }
        /// <summary>
        /// Пробег транспорта
        /// </summary>
        int Distance { get; set; }
        /// <summary>
        /// метод для расчета расхода топлива
        /// </summary>
        /// <returns>Расход топлива</returns>
        double IsCanTravelDistance();

    }
}
