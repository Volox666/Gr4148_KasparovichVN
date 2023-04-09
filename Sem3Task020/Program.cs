// №20
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

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

            double CalcLen2D(int x1, int y1, int x2, int y2) // расчет длины отрезка
            {
                double res = 0;
                res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));  // по теореме пифагора
                return res;
            }

            int x1 = ReadData("Введите координату X1: ");
            int y1 = ReadData("Введите координату Y1: ");
            int x2 = ReadData("Введите координату X2: ");
            int y2 = ReadData("Введите координату Y2: ");

            
            double lenAB = CalcLen2D(x1, y1, x2, y2);

            Console.WriteLine("Длина отрезка = "+ lenAB);



        }
    }
}