using System;
using NUnit.Framework;
using Transport;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса DistanceChecker
    /// </summary>
    [TestFixture]
    public class DistanceCheckerTest
    {
        /// <summary>
        /// Тестирование свойства distance
        /// </summary>
        /// <param name="distance"></param>
        [Test]
        [TestCase(1, TestName = "Тестирование distance при присваивании 1.", ExpectedResult = 1)]
        [TestCase(525, TestName = "Тестирование distance при присваивании 0.",ExpectedResult = 525)]
        [TestCase(-1, TestName = "Тестирование distance при присваивании -1",
            ExpectedException=typeof(ArgumentException))]
        [TestCase(500, TestName = "Тестирование distance при присваивании 500", 
            ExpectedResult = 500)]
        [TestCase(0, TestName = "Тестирование distance при присваивании 0",
            ExpectedException=typeof(ArgumentException))]
        public int DistanceTest(int distance)
        {
            return DistanceChecker.DistanceValue(distance);
        }
    }
}
