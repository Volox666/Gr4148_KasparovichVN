// №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

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

            int[] Gen1DArr(int len, int maxValue, int minValue)  // метод заполняет массив случайными числами
            {
                if (minValue > maxValue) // проверка 
                {
                    int buf = minValue;
                    minValue = maxValue;
                    maxValue = buf;
                }
                int[] arr = new int[len];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = new Random().Next(minValue, maxValue + 1);
                }
                return arr;
            }

            void Print1DArrInt(int[] arr) // метод вывода массива в консоль
            {
                System.Console.Write("[");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    System.Console.Write(arr[i] + ", ");
                }
                System.Console.WriteLine(arr[arr.Length - 1] + "]");
            }

            int[] OutArr(int[] arr) //Метод копирования массива
            {
                int[] outArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    outArr[i] = arr[i];
                }
                return outArr;
            }

            int lenArr = ReadData("Введите размер массива");
            int[] arr = Gen1DArr(lenArr, 100, 10);
            Print1DArrInt(arr);
            Print1DArrInt(OutArr(arr));
            
        }
    }
}