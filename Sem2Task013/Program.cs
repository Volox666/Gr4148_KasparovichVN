// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

using System;
namespace project
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите число");
            string? input = Console.ReadLine();
            int inLeng = input.Length;

            if (inLeng < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                if (inLeng > 10)
                {
                    Console.WriteLine("В числе больше 10 знаков");
                }
                else
                {
                    int[] arrayInput = new int[inLeng];                   // массив куда будет разложено число равный числу цифр
                    for (int count = 0; count < inLeng; count++)
                    {
                        arrayInput[count] = int.Parse(input[count].ToString()); // число переводится в массив
                    }

                    Console.WriteLine(arrayInput[2]);

                }
            }

        }
    }
}
