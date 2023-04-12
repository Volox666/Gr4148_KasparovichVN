// №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;
namespace project
{
    class Program
    {
        static void Main()
        {

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

            int ElemRangeCount(int[] arr, int rangeMin, int rangeMax )
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i]>rangeMin  && arr[i]<rangeMax) count++;
                }
                return count;
            }


            int[] res = Gen1DArr(123, 200, 0);
            Print1DArr(res);   
            int countEl = ElemRangeCount(res, 10, 99);
            System.Console.WriteLine("Злементов: " + countEl);  

            
        }
    }
}
