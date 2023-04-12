// №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.
// Например:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма
// отрицательных равна -20.

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

            int globPosSum = 0;
            int globNegSum = 0;

            void NegPosSumV1(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0) globPosSum += arr[i];
                    else globNegSum += arr[i];

                }
            }


            int[] NegPosSumV2(int[] arr)
            {
                int positivSum = 0;
                int negativSum = 0;
                int[] outArr = new int[2];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        positivSum += arr[i];
                    }
                    else
                    {
                        negativSum += arr[i];
                    }

                }
                outArr[0] = positivSum;
                outArr[1] = negativSum;
                return outArr;
            }

            (int positiv, int negotiv) NegPosSumV3(int[] arr)
            {
                int positivSum = 0;
                int negativSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        positivSum += arr[i];
                    }
                    else
                    {
                        negativSum += arr[i];
                    }

                }
                return (positivSum, negativSum);
            }


            int[] testArr = Gen1DArr(12, -9, 9);
            NegPosSumV1(testArr);
            int[] res = NegPosSumV2(testArr);
            (int positiv, int negotiv) sum = NegPosSumV3(testArr);
            Print1DArr(testArr);
            System.Console.WriteLine("Сумма положительных чисел в массиве: " + globPosSum);
            System.Console.WriteLine("Сумма отрицательных чисел в массиве: " + globNegSum);
            System.Console.WriteLine();
            System.Console.WriteLine("Сумма положительных чисел в массиве: " + res[0]);
            System.Console.WriteLine("Сумма отрицательных чисел в массиве: " + res[1]);
            System.Console.WriteLine();
            System.Console.WriteLine("Сумма положительных чисел в массиве: " + sum.positiv);
            System.Console.WriteLine("Сумма отрицательных чисел в массиве: " + sum.negotiv);




        }
    }
}