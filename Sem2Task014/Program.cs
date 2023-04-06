// Задача №14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23.

using System;
namespace project
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());

            bool test1 = (num % 7 == 0);
            bool test2 = (num % 23 == 0);
            // && - логическое "и"
            // || - логическое "или"
            if (test1 && test2) Console.WriteLine("Число кратно 7 и 23 ");
            else Console.WriteLine("Число не кратно 7 и 23");


        }
    }
}
