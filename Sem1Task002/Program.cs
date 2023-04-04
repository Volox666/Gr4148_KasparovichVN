// Считываем данные с консоли
Console.WriteLine("Enter day weak");
string? dayLine = Console.ReadLine();
if (dayLine != null)
{
    string[] dayWeek = new string[7];
    dayWeek[0] = "Monday";
    dayWeek[1] = "Tuesday";
    dayWeek[2] = "Wednesday";
    dayWeek[3] = "Thursday";
    dayWeek[4] = "Fraiday";
    dayWeek[5] = "Saturday";
    dayWeek[6] = "Sanday";

    //Парсим введенное число
    int day = int.Parse(dayLine);
    Console.WriteLine(dayWeek[day -1]);
    
}



