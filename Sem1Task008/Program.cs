// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

using System;
namespace project{
  class Program{
    static void Main(){
     
      Console.WriteLine("Введите число");
      int num = Convert.ToInt32(Console.ReadLine());  // Проверка на не пустой символ и перевод в инт 
      
      int count = 2;
      while(count<=num) 
      {        
        Console.Write(count+" ");
        count = count + 2;
      }
      
    
    }
  }
 }
