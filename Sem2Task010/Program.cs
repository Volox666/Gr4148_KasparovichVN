﻿// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. 

using System;
namespace project
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите трехзначное число");
            string input = Console.ReadLine();
            Console.WriteLine("{0}->{1}", input, input[1]);


        }
    }
}