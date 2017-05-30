using System;
using NUnit.Framework;
using Transport;

namespace UnitTests.Transport
{
    /// <summary>
    /// Набор тестов для класса HybridCar
    /// </summary>
    [TestFixture]
    public class HybridCarTest
    {
        /// <summary>
        /// Тестирование свойств PowerOfBattery
        /// </summary>
        /// <param name="powerOfBattery"></param>
        [Test]
        [TestCase(20, TestName = "Тестирование PowerOfBattery при присваивании 20", ExpectedResult = 20)]
        [TestCase(55, TestName = "Тестирование PowerOfBattery при присваивании 55", ExpectedResult = 55)]
        [TestCase(89, TestName = "Тестирование PowerOfBattery при присваивании 89", ExpectedResult = 89)]
        [TestCase(0, TestName = "Тестирование PowerOfBattery при присваивании 0",
            ExpectedException = typeof (ArgumentException))]
        [TestCase(301, TestName = "Тестирование PowerOfBattery при присваивании 301",
            ExpectedException = typeof (ArgumentException))]

        public int PowerOfBatteryTest(int powerOfBattery)
        {
            var hybridCar = new HybridCar();
            hybridCar.PowerOfBattery = powerOfBattery;
            return powerOfBattery;
        }

        /// <summary>
        /// Тестирование свойства TheCurrentAmountOfFuel
        /// </summary>
        /// <param name="theCurrentAmountOfFuel"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании 0", ExpectedResult = 0)]
        [TestCase(988, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании 988", ExpectedResult = 988)]
        [TestCase(1000, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании 1000", ExpectedResult = 1000)]
        [TestCase(-1, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании -1",
            ExpectedException = typeof (ArgumentException))]
        [TestCase(1001, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании 1001",
            ExpectedException = typeof (ArgumentException))]
        public int TheCurrentAmountOfFuelTest(int theCurrentAmountOfFuel)
        {
            var hybridCar = new HybridCar();
            hybridCar.TheCurrentAmountOfFuel = theCurrentAmountOfFuel;
            return theCurrentAmountOfFuel;
        }


        /// <summary>
        /// Тестирование свойств ElectricityConsumption
        /// </summary>
        /// <param name="electricityConsumption"></param>

        [Test]
        [TestCase(25, TestName = "Тестирование ElectricityConsumption при присваивании значения 25",
            ExpectedResult = 25)]
        [TestCase(50, TestName = "Тестирование ElectricityConsumptionпри присваивании значения 50",
            ExpectedResult = 50)]
        [TestCase(38, TestName = "Тестирование ElectricityConsumption при присваивании значения 38",
            ExpectedResult = 38)]
        [TestCase(-1, TestName = "Тестирование ElectricityConsumption при присваивании значения -1",
            ExpectedException = typeof (ArgumentException))]
        [TestCase(0, TestName = "Тестирование ElectricityConsumptionPer100km при присваивании значения 0",
            ExpectedException = typeof (ArgumentException))]
        public int ElectricityConsumptionTest(int electricityConsumption)
        {
            var hybridCar = new HybridCar();
            hybridCar.ElectricityConsumption = electricityConsumption;
            return electricityConsumption;
        }

        /// <summary>
        /// Тестирование свойства CurrentAmountOfElectricity
        /// </summary>
        /// <param name="currentAmountOfElectricity"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование CurrentAmountOfElectricity при присваивании 0",
            ExpectedResult = 0)]
        [TestCase(988, TestName = "Тестирование CurrentAmountOfElectricity при присваивании 988",
            ExpectedResult = 988)]
        [TestCase(1000, TestName = "Тестирование CurrentAmountOfElectricity при присваивании 1000",
            ExpectedResult = 1000)]
        [TestCase(-120, TestName = "Тестирование CurrentAmountOfElectricity при присваивании -120",
            ExpectedException = typeof (ArgumentException))]
        [TestCase(20001, TestName = "Тестирование CurrentAmountOfElectricity при присваивании 20001",
            ExpectedException = typeof (ArgumentException))]
        public int CurrentAmountOfElectricityTest(int currentAmountOfElectricity)
        {
            var hybridCar=new HybridCar();
            hybridCar.CurrentAmountOfElectricity = currentAmountOfElectricity;
            return currentAmountOfElectricity;
        }

        /// <summary>
        /// Тестирование метода IsCanTravelDistance
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="currentAmountOfElectricity"></param>
        /// <param name="theCurrentAmountOfFuel"></param>
        [Test]
        [TestCase(1, 1,1 , TestName = "Тестирование метода IsCanTravelDistance при значениях 1,1,1",
            ExpectedResult = 100)]
        [TestCase(450, 100, 200, TestName = "Тестирование метода IsCanTravelDistance при значениях 450,100,200",
            ExpectedResult = 425.0)]
        [TestCase(0, 100, 0, TestName = "Тестирование IsCanTravelDistance при присваивании значений 0, 100, 0",
            ExpectedException = typeof (ArgumentException))]
        [TestCase(-12, -12, 0, TestName = "Тестирование IsCanTravelDistance при присваивании значений -12, -12, 0",
            ExpectedException = typeof (ArgumentException))]
        public double IsCanTravelDistanceTest(int distance, int currentAmountOfElectricity, int theCurrentAmountOfFuel)
        {
            var hybridCar=new HybridCar();
            hybridCar.CurrentAmountOfElectricity = currentAmountOfElectricity;
            hybridCar.TheCurrentAmountOfFuel = theCurrentAmountOfFuel;
            hybridCar.Distance = distance;
            return hybridCar.IsCanTravelDistance();
        }
    }
}