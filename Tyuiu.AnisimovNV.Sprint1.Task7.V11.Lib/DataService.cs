using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double part1 = Math.Pow(Math.Log(Math.Sin(x)), x) / Math.Log(1 + Math.Pow(x, 2));
            double part2 = y - Math.Sqrt(Math.Abs(x));

            double result = part1 + part2;
            return Math.Round(result, 3, MidpointRounding.AwayFromZero);
        }
    }
}