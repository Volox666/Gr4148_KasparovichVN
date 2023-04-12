// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

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

            void Print1DArr(double[] arr) // метод вывода массива в консоль
            {
                System.Console.Write("[");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    System.Console.Write(arr[i] + ", ");
                }
                System.Console.WriteLine(arr[arr.Length - 1] + "]");
            }

            double[] Gen1DArrDouble(int len, int maxValue, int minValue)  // метод заполняет массив случайными числами
            {
                if (minValue > maxValue) // проверка 
                {
                    int buf = minValue;
                    minValue = maxValue;
                    maxValue = buf;
                }
                double[] arr = new double[len];

                for (int i = 0; i < len; i++)
                {
                    int var = new Random().Next(minValue, maxValue + 1); // случайное число из диапазона
                    arr[i] = new Random().NextDouble() * var; // вещественный множитель от (0 до 1) на случайное число
                }
                return arr;
            }

            double DifMinMax(double[] arr) // метод считает разницу между максимальным и минимальным элементами массива
            {
                double res = 0;
                double min = double.MaxValue;  // максимально возможное число
                double max = double.MinValue;  // минимально возможное число
                for (int i = 0; i < arr.Length; i++)
                {
                    if (min > arr[i]) min = arr[i];
                    if (max < arr[i]) max = arr[i];
                }
                res = max - min;
                return res;
            }

            // для задачи со звездочкой

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

            int[] InsertionSort(int[] mass) //Сортировка методом вставки
            {
                for (int i = 1; i < mass.Length; i++)
                {
                    int newElement = mass[i];
                    int location = i - 1;
                    while (location >= 0 && mass[location] > newElement)
                    {
                        mass[location + 1] = mass[location];
                        location = location - 1;
                    }
                    mass[location + 1] = newElement;
                }
                return mass;
            }

            // int[] SortArray(int[] inputArray)
            // {
            //     int[] countArray = new int[inputArray.Max() + 1];
            //     for (int i = 0; i < inputArray.Length; i++)
            //     {
            //         countArray[inputArray[i]]++;
            //     }
            //     int[] sortedArray = new int[inputArray.Length];
            //     int sortedArrayIndex = 0;
            //     for (int i = countArray.Length - 1; i >= 0; i--)
            //     {
            //         for (int j = 0; j < countArray[i]; j++)
            //         {
            //             sortedArray[sortedArrayIndex++] = i;
            //         }
            //     }
            //     return sortedArray;


                int lenArr = ReadData("Введите размер массива");
                double[] res = Gen1DArrDouble(lenArr, 15, 0);
                Print1DArr(res);
                double dif = DifMinMax(res);
                System.Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + dif);

                int[] arrayInt = Gen1DArr(lenArr, 15, 0);
                Print1DArrInt(arrayInt);
                int[] arrayIns = InsertionSort(arrayInt);
                System.Console.WriteLine("Сортирвка методом вставки");
                Print1DArrInt(arrayIns);



            }
        }
    }