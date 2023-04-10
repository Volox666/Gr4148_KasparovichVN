// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки


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
            int Sum(int num)
            {
                int res = 0;
                while (num > 0)
                {
                    res += num % 10;   // Берет последнюю цифру
                    num = num / 10;    // уменьшает число на разряд
                }
                return res;
            }
            int num = ReadData("Введите число: ");
            Console.WriteLine($"Сумма цифр в числе: { Sum(num)}");


        }
    }
}