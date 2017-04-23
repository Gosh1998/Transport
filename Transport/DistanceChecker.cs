using System;

namespace Transport
{
    /// <summary>
    /// Проверка для ввода 
    /// </summary>
    public class DistanceChecker
    {
        public static int DistanceValue(int distance)
        {
            if (distance <= 0)
            {
                 throw new ArgumentException("Значение параметра должно быть положительным");
            }
            return distance;
        }
    }
}