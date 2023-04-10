// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

using System;
namespace project
{
    class Program
    {
        static void Main()
        {

            int ReadData(string msg) // Метод читает данные от пользователя
            {
                System.Console.WriteLine(msg);
                int res = int.Parse(Console.ReadLine() ?? "0");
                return res;
            }

            int Step(int osnow, int pow) //метод возводит в степень
            {
                int powRez = 1;
                for (int i = 0; i < pow; i++) powRez *= osnow;
                return powRez;
            }

            int osnow = ReadData("Введите основание: ");
            int pow = ReadData("Введите степень: ");
            if (pow < 0) Console.WriteLine("Показатель степени должен быть положительный");
            else
            {
                int rez = Step(osnow, pow);
                Console.WriteLine("Число {0} в степени {1} равно: {2}", osnow, pow, rez);
            }


        }
    }
}