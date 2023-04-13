// №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

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

            string FibNum(int num) //Метод считает числа Фибаначи и записывает в строку
            {
                string res = "0 1";
                long first = 0;
                long last = 1;
                for (int i = 2; i <= num; i++)
                {
                    res=res +" "+ (first+last);
                    (first,last)=(last, last + first);
                }                
                 return res;
            }

            int num = ReadData("Введите число:");
            System.Console.WriteLine("Числа Фибоначи: "+FibNum(num));
        }
    }
}