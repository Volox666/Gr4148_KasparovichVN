// №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

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

            void PrintResult(string msg, int res) // метод вывода
            {
                System.Console.WriteLine(msg + res);
            }

            int CountDigit(int numA)  // метод считает цифры
            {
                int res = 0;
                while (numA > 0)
                {
                    res++;
                    numA = numA/10; 
                }
                return res;
            }

            int numberA = ReadData("Введите число:");

            DateTime d1 = DateTime.Now;     //Проверка на скорость выполнения
            int res = CountDigit(numberA);
            System.Console.WriteLine(DateTime.Now - d1);

            
            PrintResult("Количество цифр в числе:", (int)res);
          

        }
    }
}