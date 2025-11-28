using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AnisimovNV.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double deposit, double rate, double days)
        {
            double income = (deposit * rate * days) / (365 * 100);
            return Math.Round(income, 3); // Округляем до 3 знаков
        }

        // Методы интерфейса (заглушки)
        public double HowManySquares(double a, double b, double c)
        {
            return 0;
        }

        public double ReverseNumber(double number)
        {
            return 0;
        }
    }
}