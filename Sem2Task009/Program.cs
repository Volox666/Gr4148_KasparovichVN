/* Задача №9
Напишите программу, которая выводит случайное
число из отрезка [10, 99] и показывает наибольшую
цифру числа. */

System.Random numSintezator = new System.Random();

// Var 1

int rndNum = numSintezator.Next(10, 100);
System.Console.WriteLine(rndNum);
short firstNum = (short)(rndNum/10);
short secondNum = (short)(rndNum%10);
if(firstNum>secondNum)
{
    System.Console.WriteLine("Первое число {0} больше второго {1}", firstNum, secondNum );
}
else
{
    System.Console.WriteLine("Второе число {1} больше первого {0} ", firstNum, secondNum );
 
}

// Var 2

char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray(); // 23 сначала строка "23" затем массив символов ['2','3']

System.Console.WriteLine(digits);

firstNum = (short)(digits[0]-48); // переводит символ в число, -48 из-за кодировки 
secondNum = (short)(digits[1]-48);

short res =(firstNum>secondNum)?firstNum:secondNum; // <переменная> = (условие)?<значение1>:<значение2>;
System.Console.WriteLine(res);

// Var 3 большой массив с ответами [25]=5, [65]=6 и просто все ))

// int rndNum = numSintezator.Next(10, 100);
// System.Console.WriteLine(rndNum);




