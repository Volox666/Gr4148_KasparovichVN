// Считываем данные с консоли
Console.WriteLine("Введите 3-х значное число");
string? numLine = Console.ReadLine();
// Проверяем что не пустые данные
if (numLine != null)
{
    // char[] charArr = numLine.ToCharArray();
    // Console.WriteLine(charArr[charArr.Length-1]);

    //Парсим введенное число
    int num = int.Parse(numLine);
    int res = num%10;
    //num%10 остаток деления на 10
       
    //Выводим на консоль
    Console.WriteLine(res);
}
