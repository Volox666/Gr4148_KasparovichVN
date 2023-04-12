// №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

            void InversArr(int[] arr) // метод инвентирует массив
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * (-1);
                }
            }

            int[] arr = Gen1DArr(10, 10, -10);
            Print1DArr(arr);
            InversArr(arr);     // Вызов метода ссылочный
            Print1DArr(arr);
            
        }
    }
}