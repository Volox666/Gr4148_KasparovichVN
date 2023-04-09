// №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.
// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

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

            string LineGen(int num, int pow) // создает строку чисел в степени pow
            {
                string res = String.Empty;
                for (int i = 1; i <= num; i++)
                {
                    res = res + Math.Pow(i, pow) + " ";
                }
                return res;
            }

            int x = ReadData("Введите...");
            Console.WriteLine(LineGen(x, 1));   // просто числа в степени *1*
            Console.WriteLine(LineGen(x, 2));   // квадраты чисел *2*

        }
    }
}