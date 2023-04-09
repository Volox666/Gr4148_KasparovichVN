// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

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

            void LineGen2(int num, int pow) // создает массив чисел 1..num в степени pow и выводит в строку
            {
                double[] array = new double [num];
                for (int i = 1; i <= num; i++)
                {
                    array[i-1] = Math.Pow(i, pow);
                    Console.Write("{0,-5}", array[i-1]);
                }
                System.Console.WriteLine();
            }

            int x = ReadData("Введите число: ");            
            LineGen2(x, 1);   // просто числа в степени *1*
            LineGen2(x, 3);    // куб чисел *3*      
        }
    }
}
