// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

using System;
namespace project
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> dictWeek = new Dictionary<int, string>
            {
                [1] = "Рабочий ((",
                [2] = "Рабочий ((",
                [3] = "Рабочий ((",
                [4] = "Рабочий ((",
                [5] = "Рабочий ((",
                [6] = "Выходной ))",
                [7] = "Выходной ))",
            };

            Console.WriteLine("Введите номер дня недели");
            int num = int.Parse(Console.ReadLine() ?? "0");            

            if (num <= 1 && num > 7) System.Console.WriteLine("Неправильный номер дня недели");
            else Console.WriteLine("Этот день: " + dictWeek[num]);

        }
    }
}