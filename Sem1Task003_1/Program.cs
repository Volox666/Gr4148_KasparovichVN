// Считываем данные с консоли
Console.WriteLine("Enter day weak");
string? dayLine = Console.ReadLine();
// Проверяем что не пустые данные
if (dayLine != null)
{
    //Парсим введенное число
    int day = int.Parse(dayLine);
    //Супер длинная строка запроса дня недели у системы
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
    //Выводим на консоль
    Console.WriteLine(outDayOfWeek);
}