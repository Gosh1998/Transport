using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Transport;

namespace TransportConsole
{
    class Program
    {
       private static void Main()
        {
            var list = new List<ITransport>();
            var car = new Car
            {
                TheCurrentAmountOfFuel = 28
            };
            list.Add(car);

            var hybrid = new HybridCar
            {
                TheCurrentAmountOfFuel = 29,
                CurrentAmountOfElectricity = 37
            };
            list.Add(hybrid);

            var helicopter = new Helicopter
            {
                FuelConsumption = 323
            };
            list.Add(helicopter);

            foreach (var transport in list)
            {
                Console.WriteLine("{0}. Средний расход топлива  составляет {1} л",transport.GetType(),transport.IsCanTravelDistance());
            }
            Console.ReadLine();
        }
    }
}
  
