using System;
using Tyuiu.AnisimovNV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Анисимов Н. В. | ИСТНБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Анисимов Н. В. | ИСТНБ-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                   *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).  *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X первой точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y первой точки:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату X второй точки:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y второй точки:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками: {result}");

            Console.ReadLine();
        }
    }
}