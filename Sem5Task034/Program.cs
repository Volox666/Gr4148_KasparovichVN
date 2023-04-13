// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

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

            int EvenCount(int[] arr) // количество четных элементов
            {
                int res = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0) res++;
                }
                return res;
            }

            int lenArr = ReadData("Введите размер массива");
            int[] res = Gen1DArr(lenArr, 1000, 100);
            Print1DArr(res);
            int countElem = EvenCount(res);
            System.Console.WriteLine("Количество четных элементов в массиве: " + countElem);

            // Сортировка методом пузырька

            int[] BubbleSort(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - 1; j++)
                        if (array[j] > array[j + 1])
                        {
                            int t = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = t;
                        }
                return array;
            }

            // Сортировка методом подсчета

            int[] CountSort(int[] array)
            {
                int length = array.Length;

                //Create a new "output" array
                int[] output = new int[length];

                //Create a new "counting" array 
                //which stores the count of each unique number
                int[] count = new int[1000];
                for (int i = 0; i < 1000; ++i)
                {
                    count[i] = 0;
                }
                for (int i = 0; i < length; ++i)
                {
                    ++count[array[i]];
                }

                //Change count[i] so that count[i] now contains the   
                //actual position of this character in the output array.
                for (int i = 1; i <= 999; ++i)
                {
                    count[i] += count[i - 1];
                }

                //Build the output array.
                //To make this sorting algorithm stable, 
                //we are operating in reverse order. 
                for (int i = length - 1; i >= 0; i--)
                {
                    output[count[array[i]] - 1] = array[i];
                    --count[array[i]];
                }

                //Copy the output array to the final array.
                for (int i = 0; i < length; ++i)
                {
                    array[i] = output[i];
                }
                return array;
            }

            int lenArrSort = ReadData("Введите размер массива для сортировки");
            int[] resSort = Gen1DArr(lenArr, 1000,100);

            DateTime d1 = DateTime.Now;
            int[] resSortBuble = BubbleSort(resSort);
            //Print1DArr(resSortBuble);
            System.Console.WriteLine("Сортировка методом пузырька {0}",DateTime.Now - d1);

            DateTime d2 = DateTime.Now;
            int[] resSortCount = CountSort(resSort);
            //Print1DArr(resSortCount);
            System.Console.WriteLine("Сортировка методом подсчета {0}",DateTime.Now - d2);
           

        }
    }
}
