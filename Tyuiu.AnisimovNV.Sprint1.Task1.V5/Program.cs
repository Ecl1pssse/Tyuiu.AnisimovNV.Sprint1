using System;
using Tyuiu.AnisimovNV.Sprint1.Task1.V16.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Анисимов Н. В. | ИСТИБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Анисимов Н. В. | ИСТИБ-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет результат по формуле x*5*a+2*y   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("* Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("* Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("* Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, a, y);
            Console.WriteLine($"* {result}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}