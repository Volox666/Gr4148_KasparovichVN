// №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

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

            void SwapArray(int[] arr)
            {
                int buf = 0;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    buf = arr[i];
                    arr[i] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = buf;
                }
            }

            int[] SwapNewArray(int[] arr)
            {
                int[] outArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    outArr[outArr.Length - 1 - i] = arr[i];
                }
                return outArr;
            }

            int lenArr = ReadData("Введите размер массива");
            int[] testArray = Gen1DArr(lenArr, 10, 100);
            Print1DArrInt(testArray);
            int[] newTestArr = SwapNewArray(testArray);
            Print1DArrInt(newTestArr);
            SwapArray(testArray);
            Print1DArrInt(testArray);




        }
    }
}