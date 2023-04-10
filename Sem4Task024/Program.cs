// №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

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

            long SumSimple(int numA)  // метод считает сумму
            {
                long sum = 0;
                for (int i = 0; i <= numA; i++) sum += i;
                return sum;
            }

            long SumGauss(int numA)
            {
                return ((1 + (long)numA) * (long)numA) / 2;
            }

            int numberA = ReadData("Enter a");

            DateTime d1 = DateTime.Now;     //Проверка на скорость выполнения
            long res1 = SumSimple(numberA);
            System.Console.WriteLine(DateTime.Now - d1);

            DateTime d2 = DateTime.Now;
            long res2 = SumGauss(numberA);
            System.Console.WriteLine(DateTime.Now - d2);

            PrintResult("Сумма чисел от 1 до А (простой метод):", (int)res1);
            PrintResult("Сумма чисел от 1 до А (метод Гауса):", (int)res2);

        }
    }
}