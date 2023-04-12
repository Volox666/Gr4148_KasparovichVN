// №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

            int[] ConvertArr(int[] arr) // конвертация массива
            {
                int lengArr = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1; // определение длинны выходного массива 
                                                    // в зависимости от четности или нечетности исходного массива
                int[] outArr = new int[lengArr];
                for (int i = 0; i < lengArr; i++)
                {
                    outArr[i] = arr[i]*arr[arr.Length-1-i];
                }
                return outArr;
            }

            int lenArr = ReadData("Введите размер массива");
            int[] res = Gen1DArr(lenArr, 15, 0);
            Print1DArr(res);
            int[] resOut = ConvertArr(res);
            Print1DArr(resOut);



        }
    }
}