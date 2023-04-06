// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет

using System;
namespace project{
  class Program{
    static void Main(){
     
      Console.WriteLine("Введите число");
      int num = Convert.ToInt32(Console.ReadLine());  // Проверка на не пустой символ и перевод в инт 

bool res = (num%2 == 0);

if(res) System.Console.WriteLine("Число четное");
      else System.Console.WriteLine("Число не четное");
    
    }
  }
 }
