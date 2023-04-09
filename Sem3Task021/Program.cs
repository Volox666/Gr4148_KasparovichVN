// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

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

            double CalcLen3D(int x1, int y1,int z1, int x2, int y2, int z2) // расчет длины отрезка
            {
                double res = 0;
                res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));  // по теореме пифагора
                return res;
            }

            int x1 = ReadData("Введите координату X1: ");
            int y1 = ReadData("Введите координату Y1: ");
            int z1 = ReadData("Введите координату Z1: ");
            int x2 = ReadData("Введите координату X2: ");
            int y2 = ReadData("Введите координату Y2: ");
            int z2 = ReadData("Введите координату Z2: ");

            
            double lenAB = CalcLen3D(x1, y1, z1, x2, y2, z2);

            Console.WriteLine("Длина отрезка = "+ lenAB);

        }
    }
}