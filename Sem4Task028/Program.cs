// №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120


using System.Numerics;
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

            void PrintResult(string msg, BigInteger res) // метод вывода
            {
                System.Console.WriteLine(msg + res);
            }

            BigInteger Factor(int numA)  // метод считает факториал
            {
                BigInteger res = 1;
                for (int i = 1; i <= numA; i++)
                {
                    res = res * i;
                }
                return res;
            }

            int numberA = ReadData("Введите число:");

            DateTime d1 = DateTime.Now;     //Проверка на скорость выполнения
            BigInteger res = Factor(numberA);
            System.Console.WriteLine(DateTime.Now - d1);

            
            PrintResult("Факториал:", (BigInteger)res);
          

        }
    }
}