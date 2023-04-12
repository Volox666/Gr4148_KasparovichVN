// №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
                System.Console.WriteLine(arr[arr.Length - 1] + "]");
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
            void SearchElemInArr(int elem, int[] arr)
            {
                bool elemFind = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == elem)
                    {
                        System.Console.WriteLine("Злемент найден в позиции: "+i);
                        elemFind = true;
                    }
                }
                if (elemFind == false) 
                {
                    System.Console.WriteLine("Злемент не найден");
                }
            }

           // int elem = ReadData("Введите число для поиска:");
            int[] res = Gen1DArr(10, 10, -10);
            Print1DArr(res);
            int elem = ReadData("Введите число для поиска:");
            SearchElemInArr(elem, res);


        }
    }
}