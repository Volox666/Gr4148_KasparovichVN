// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.

System.Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");
System.Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

void SqrTest(int a, int b)  // метод который можно вызвать в программе
{
    if(a==b*b) System.Console.WriteLine(a + " квадрат " + b);
    else System.Console.WriteLine(a + " не квадрат " + b);
}

SqrTest(num1, num2);
SqrTest(num2, num1);