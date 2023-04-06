// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

using System;
namespace project{
  class Program{
    static void Main(){
     
      Console.WriteLine("Введите первое число");
      int num1 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Введите второе число");
      int num2 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Минимальное число: " + Math.Min(num1, num2));
    
    }
  }
 }
