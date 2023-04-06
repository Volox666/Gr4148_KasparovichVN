// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

using System;
namespace project{
  class Program{
    static void Main(){
     
      Console.WriteLine("Введите первое число");
      int num1 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Введите второе число");
      int num2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Введите третье число");
      int num3 = Convert.ToInt32(Console.ReadLine());

      int maxNum = Math.Max(Math.Max(num1, num2), num3); //Math.Max() метод возвращает большее из двух чисел
    
      Console.WriteLine("Максимальное число: " + maxNum);
    
    }
  }
 }
