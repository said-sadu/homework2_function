Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("(это выходной день)");
    }
    else if (day < 1 || day > 7)
    {
        Console.WriteLine("такого дня недели нет");
    }
    else Console.WriteLine("(это не выходной день) ");
}

DayOfTheWeek(day);