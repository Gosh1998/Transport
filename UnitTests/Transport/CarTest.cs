using System;

using NUnit.Framework;
using Transport;

namespace UnitTests.Transport
{
    /// <summary>
    /// Набор тестов для класса Car
    /// </summary>
    [TestFixture]
    public class CarTest
    {
        /// <summary>
        /// Тестирование свойства TheCurrentAmountOfFuel
        /// </summary>
        /// <param name="theCurrentAmountOfFuel"></param>
        [Test]
        [TestCase(0, TestName = "Тестирование свойства TheCurrentAmountOfFuel при присваивании 0",
            ExpectedResult =0)]
        [TestCase(1500, TestName = "Тестирование свойства TheCurrentAmountOfFuel при присваивании 1500",
             ExpectedResult =1500 )]
        [TestCase(800, TestName = "Тестирование свойства TheCurrentAmountOfFuel при присваивании 800", 
            ExpectedResult = 800)]
        [TestCase(1600, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании 1600 ",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(-1, TestName = "Тестирование TheCurrentAmountOfFuel при присваивании -1",
            ExpectedException = typeof(ArgumentException))]
        public double TheCurrentAmountOfFuelTest(double theCurrentAmountOfFuel)
        {
            var car=new Car();
            car.TheCurrentAmountOfFuel = theCurrentAmountOfFuel;
            return theCurrentAmountOfFuel;
        }

        /// <summary>
        /// Тестирование свойства IsCanTravelDistance
        /// </summary>
        /// <param name="theCurrentAmountOfFuel"></param>
        /// <param name="distance"></param>
        [Test]
        [TestCase(1, 2, TestName = "Тестирвание метода IsCanTravelDistance со значениями 1 и 2",
            ExpectedResult=50)]
        [TestCase(5,5,TestName = "Тестирование метода IsCanTravelDistance со значением 5 и 5 ",
            ExpectedResult = 100)]
        [TestCase(0, 0, TestName = "Тестирование метода IsCanTravelDistance при присваивании 0 и 0",
            ExpectedException = typeof(ArgumentException))]
        [TestCase(0, 1,TestName = "Тестирование метода IsCanTravelDistance  при присваивании 0 и 1 ",
            ExpectedResult = 0)]

        public double TestIsCanTravelDistance(double theCurrentAmountOfFuel, int distance)
        {
            var car = new Car();
            car.TheCurrentAmountOfFuel = theCurrentAmountOfFuel;
            car.Distance = distance;
            return car.IsCanTravelDistance();
        }
    }
}