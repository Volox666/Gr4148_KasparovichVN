// Задача №17
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.
// Например:
// x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

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

            void PrintQuterTest(int x, int y) //Метод определяет четверть по координатам точки
            {

                if(x>0 && y>0) Console.WriteLine("Точка в 1 четверти");
                if(x>0 && y<0) Console.WriteLine("Точка в 2 четверти");
                if(x<0 && y<0) Console.WriteLine("Точка в 3 четверти");
                if(x<0 && y>0) Console.WriteLine("Точка в 4 четверти");

            }

            int coordX = ReadData("Введите координату X: ");
            int coordY = ReadData("Введите координату Y: ");
            PrintQuterTest(coordX, coordY);

        }
    }
}