// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

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


            bool PalTest(int num)   // Метод проверяет является ли число палиномом
            {
                bool res = false;
                int d1 = num / 10000;
                int d5 = num % 10;
                int d2 = (num / 1000) % 10;
                int d4 = (num / 10) % 10;
                if (d1 == d5 && d2 == d4) res = true;
                return res;
            }

            Dictionary<int, int> MakeDictPal()  // Метод создает словарь 4-х значных палиномов
            {
                Dictionary<int, int> dictPalinam = new Dictionary<int, int>();

                int j = 1;
                for (int i = 1000; i < 10000; i++)
                {

                    int d1 = i / 1000;
                    int d4 = i % 10;
                    int d2 = (i / 100) % 10;
                    int d3 = (i / 10) % 10;

                    if (d1 == d4 && d2 == d3)
                    {
                        dictPalinam.Add(j, i);
                        j++;
                    }
                }
                return dictPalinam;
            }

            int PalConv(int pal) // Метод преобразовывает пятизначное число в четырехзначное убирая среднюю цифру
            {
                int d1 = pal / 10000;
                int d5 = pal % 10;
                int d2 = (pal / 1000) % 10;
                int d4 = (pal / 10) % 10;
                int res = d1 * 1000 + d2 * 100 + d4 * 10 + d5;
                return res;
            }

            int paly = ReadData("Введите пятизначное число: ");
            if (paly > 9999 && paly < 100000)
            {
                bool res = PalTest(paly);         
                if (res) System.Console.WriteLine("Это число палином");
                else System.Console.WriteLine("Это число не является палиномом");
            }
            else System.Console.WriteLine("Ошибка ввода данных");

// Второй способ


            // int paly = ReadData("Введите пятизначное число: ");
            if (paly > 9999 && paly < 100000)
            {
                int palyConv = PalConv(paly);                           // 5 значное число переводится в 4 значное 
                Dictionary<int, int> dictPalinam = MakeDictPal();       // создается словарь 4 значных палиномов
                bool res = dictPalinam.ContainsValue(palyConv);         // проверяется есть ли в словаре
                if (res) System.Console.WriteLine("Это число палином");
                else System.Console.WriteLine("Это число не является палиномом");
            }
            else System.Console.WriteLine("Ошибка ввода данных");

        }
    }
}