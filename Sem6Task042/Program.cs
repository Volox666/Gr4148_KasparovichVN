// №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

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

            string DecToBin(int a)
            {
                string res = string.Empty;
                while (a>0)
                {
                    res+=a%2;
                    a=a/2;
                }
                 return res;
            }

            int a = ReadData("Введите десятичное число:");
            System.Console.WriteLine("Двоичное число:"+DecToBin(a));            

        }
    }
}