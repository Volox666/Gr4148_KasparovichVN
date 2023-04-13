// №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

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

            bool TrianTest(int a, int b, int c)
            {
                if ((a<=b+c)&&(b<=c+a)&&(c<=a+b)) return true;
                else return false;
            }

            int a = ReadData("Введите сторону А:");
            int b = ReadData("Введите сторону В:");
            int c = ReadData("Введите сторону С:");

            if (TrianTest(a,b,c)) System.Console.WriteLine("Такой треугольник существует");
            else System.Console.WriteLine("Такой треугольник не существует");

        }
    }
}