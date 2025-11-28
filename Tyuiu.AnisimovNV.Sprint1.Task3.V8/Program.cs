using System;
using Tyuiu.AnisimovNV.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AnisimovNV.Sprint1.Task3.V8
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Анисимов Н. В. | ИСТНБ-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите величину вклада (руб.):");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок вклада (дней):");
            double days = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процентную ставку (годовых):");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double income = ds.IncomeAmount(deposit, rate, days);
            double total = deposit + income;

            Console.WriteLine($"Доход: {income:F3} руб."); // F3 для 3 знаков
            Console.WriteLine($"Сумма по окончании срока вклада: {total:F3} руб.");

            Console.ReadLine();
        }
    }
}