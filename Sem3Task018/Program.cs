// Задача №18
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

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

            void PrintAnswer(int num) 
            {
                if(num==1) Console.WriteLine(" X>0, Y>0 ");
                if(num==2) Console.WriteLine(" X>0, Y<0 ");
                if(num==3) Console.WriteLine(" X<0, Y<0 ");
                if(num==4) Console.WriteLine(" X<0, Y>0 ");
            }

            int nom = ReadData("Введите номер четверти: ");
            if(nom>0 && nom<5) PrintAnswer(nom);
            else Console.WriteLine("Неверное значение");

        }
    }
}