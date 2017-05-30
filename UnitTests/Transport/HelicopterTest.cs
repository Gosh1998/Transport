using System;
using NUnit.Framework;
using Transport;

namespace UnitTests.Transport
{
    /// <summary>
    /// Набор тестов для класса Helicopter
    /// </summary>
    [TestFixture]
    public class HelicopterTest
    {
        /// <summary>
        /// Тестирование свойства FuelConsumption
        /// </summary>
        /// <param name="fuelConsumption"></param>
        [Test]
        [TestCase(101, TestName = "Тестирование FuelConsumption при присваивании 101",ExpectedResult = 101)]
        [TestCase(200, TestName = "Тестирование FuelConsumption при присваивании 200",ExpectedResult = 200)]
        [TestCase(-1, TestName = "Тестирование FuelConsumption при присваивании -1",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(25, TestName = "Тестирование FuelConsumption при присваивании 25",
            ExpectedException = typeof(ArgumentException))]
        public int FuelConsumptionTest(int fuelConsumption)
        {
            var helicopter = new Helicopter();
            helicopter.FuelConsumption = fuelConsumption;
            return fuelConsumption;
        }

        /// <summary>
        /// Тестирование свойства Speed
        /// </summary>
        /// <param name="speed"></param>
        [Test]
        [TestCase(100, TestName = "Тестирование Speed при присваивании 100", ExpectedResult = 100)]
        [TestCase(200, TestName = "Тестирование Speed при присваивании 200", ExpectedResult = 200)]
        [TestCase(390, TestName = "Тестирование Speed при присваивании 390",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(0, TestName = "Тестирование Speed при присваивании 0",
            ExpectedException = typeof(ArgumentException))]
        public int SpeedTest(int speed)
        {
            var helicopter = new Helicopter();
            helicopter.Speed = speed;
            return speed;
        }

        /// <summary>
        /// Тестирование свойства VolumeOfTheTank
        /// </summary>
        /// <param name="volumeOfTheTank"></param>
        [Test]
        [TestCase(50, TestName = "Тестирование VolumeOfTheTank при присваивании 50", ExpectedResult = 50)]
        [TestCase(80, TestName = "Тестирование VolumeOfTheTank при присваивании 80", ExpectedResult = 80)]
        [TestCase(500, TestName = "Тестирование VolumeOfTheTank при присваивании 500",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(0, TestName = "Тестирование VolumeOfTheTank при присваивании 0",
            ExpectedException = typeof(ArgumentException))]
        public int VolumeOfTheTank(int volumeOfTheTank)
        {
            var helicopter = new Helicopter();
            helicopter.VolumeOfTheTank = volumeOfTheTank;
            return volumeOfTheTank;
        }
        ///<summary>
        /// Тестирование свойства FuelConsumptionPerHour
        /// </summary>
        /// <param name="fuelConsumptionPerHour"></param>
        [Test]
        [TestCase(390, TestName = "Тестирование FuelConsumptionPerHour при присваивании 390", ExpectedResult = 390)]
        [TestCase(400, TestName = "Тестирование FuelConsumptionPerHour при присваивании 400", ExpectedResult = 400)]
        [TestCase(370, TestName = "Тестирование FuelConsumptionPerHour при присваивании 370",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(0, TestName = "Тестирование FuelConsumptionPerHour при присваивании 0",
            ExpectedException = typeof(ArgumentException))]
        public double FuelConsumptionPerHour(double fuelConsumptionPerHour)
        {
            var helicopter = new Helicopter();
            helicopter.FuelConsumptionPerHour = fuelConsumptionPerHour;
            return fuelConsumptionPerHour;
        }
        /// <summary>
        /// Тестирование метода IsCanTravelDistance
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="fuelConsuption"></param>
        [Test]
        [TestCase(2000, 200, TestName = "Тестирвание метода IsCanTravelDistance со значениями 100 и 2000",
            ExpectedResult = 10)]
        [TestCase(100, 150, TestName = "Тестирвание метода IsCanTravelDistance со значениями 100 и 100",
            ExpectedResult = 150)]
        [TestCase(0, 20, TestName = "Тестирвание метода IsCanTravelDistance со значениями 0 и 20",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(-1, 0, TestName = "Тестирвание метода IsCanTravelDistance со значениями -1 и 0",
            ExpectedException = typeof(ArgumentException))]

        public  double IsCanTravelDistanceTest(int distance, int fuelConsuption)
        {
           var helicopter=new Helicopter();
            helicopter.Distance = distance;
            helicopter.FuelConsumption = fuelConsuption;
            return helicopter.IsCanTravelDistance();
        }
    }
}