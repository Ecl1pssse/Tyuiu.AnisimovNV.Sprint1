using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double HowManySquares(double a, double b, double c)
        {
            // Для этого задания не используется, но должен быть реализован
            return 0;
        }

        public double ReverseNumber(double number)
        {
            // Для этого задания не используется, но должен быть реализован  
            return 0;
        }

        // ДОБАВЛЯЕМ НАШ МЕТОД ДЛЯ ФОРМУЛЫ
        public double CalculateFormula(double x, double y)
        {
            double numerator = Math.Sqrt(7 + Math.Abs(x - y));
            double denominator = 3 * x * Math.Pow(y, 2);
            return Math.Round(numerator / denominator, 3);
        }
    }
}