// Считываем данные с консоли
string? inLine = Console.ReadLine();

if (inLine != null)
{

    //Парсим введенное число

    int inNumber = int.Parse(inLine);

    //Находим квадрат числа

    int outNumber = inNumber * inNumber;

    //Выводим данные в консоль
    
    Console.WriteLine(outNumber);

}
