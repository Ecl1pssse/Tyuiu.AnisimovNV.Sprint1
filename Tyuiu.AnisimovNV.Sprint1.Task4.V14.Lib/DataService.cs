using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sqrt(7 + Math.Abs(x - y));
            double denominator = 3 * x * Math.Pow(y, 2);
            double result = numerator / denominator;
            return Math.Round(result, 3, MidpointRounding.AwayFromZero);
        }
    }
}