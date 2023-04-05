// Задача №12
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления.

System.Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");  // Работает быстрее
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = (num1%num2 == 0);

if(res) System.Console.WriteLine("Число кратное");
else System.Console.WriteLine("остаток деления " + num1%num2);
