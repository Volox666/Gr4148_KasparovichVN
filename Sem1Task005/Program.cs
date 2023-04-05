// Считываем данные с консоли
Console.WriteLine("Enter ");
string? numNLine = Console.ReadLine();
// Проверяем что не пустые данные
if (numNLine != null)
{
    //Парсим введенное число
    int numN = int.Parse(numNLine);
    int startNum = numN * (-1);
    //строка куда собирается результат, пустая
    string res = String.Empty;
    while (startNum <= numN)
    {
        res = res + startNum + " ";
        startNum = startNum + 1; //startNumm++;
    }
    //Выводим на консоль
    Console.WriteLine(res);
}