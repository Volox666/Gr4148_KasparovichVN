// Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа. 

int num = new Random().Next(100, 1000);
int firstNum = num/100;
int lastNum = num%10;
int newNum = firstNum*10+lastNum;
System.Console.WriteLine(num);
System.Console.WriteLine(newNum);

System.Console.WriteLine((num/100)*10+num%10);   // Второй вариант решения для опытных программистов
