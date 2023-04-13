// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.

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

            int CountPosNum(int num)
            {
                int count = 0;
                while (num > 0)
                {
                    int val = ReadData("Введите число");
                    if (val > 0) count++;
                    num = num - 1;
                }
                return count;                
            }

            int num = ReadData("Введите количество чиселА: ");
            System.Console.WriteLine("Введено {0} положительных чисел",CountPosNum(num));            
        }
    }
}