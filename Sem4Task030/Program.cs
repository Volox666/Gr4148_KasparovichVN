// №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]


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

            void Print1DArr(int[] arr) // метод вывода массива в консоль
            {
                System.Console.Write("[");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    System.Console.Write(arr[i] + ", ");
                }
                System.Console.WriteLine(arr[arr.Length-1] + "]");
            }

            int[] Gen1DArr(int len, int top, int but)  // метод заполняет массив случайными числами
            {
                int[] res = new int[len];
                for (int i = 0; i < len; i++)
                {
                    res[i] = new Random().Next(but, top+1);
                }
                return res;
            }

            int lenArr = ReadData("Введите величину массива:");           
            int[] res = Gen1DArr(lenArr, 1, 0);
            Print1DArr(res);     

            
        }
    }
}