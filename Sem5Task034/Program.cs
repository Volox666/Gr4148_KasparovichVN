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
                    if(arr[i]%2==0) res++;
                }
                return res;
            }

            int lenArr = ReadData("Введите размер массива");
            int[] res = Gen1DArr(lenArr, 15, 0);
            Print1DArr(res);
            int countElem = EvenCount(res);
            System.Console.WriteLine("Количество четных элементов в массиве: " + countElem);
            
            
            /* Сортировка методом пузырька
		void BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
				for (int j = 0; j < array.Length - 1; j++)
					if (array[j] > array[j + 1])
					{
						int t = array[j + 1];
						array[j + 1] = array[j];
						array[j] = t;
					}
		}
 
            
            */
            
            /* Сортировка методом подсчета
            
            
 void CountingSort(int[] arr)
        {

            int max = arr.Max();
            int min = arr.Min();

            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i &lt; count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i &lt; arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            for (int i = min; i &lt;= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    arr[z] = i;
                    z++;
                }
            }

            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }
        }
        
        */
            
        }
    }
}
