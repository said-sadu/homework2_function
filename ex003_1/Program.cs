Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek(int day)
{
    if (day < 1 || day > 7)
    {
        Console.WriteLine("такого дня недели нет");
    }
    else if (day == 1)
    {
        Console.WriteLine("понедельник");
    }
    else if (day == 2)
    {
        Console.WriteLine("вторник");
    }
    else if (day == 3)
    {
        Console.WriteLine("среда");
    }
    else if (day == 4)
    {
        Console.WriteLine("четверг");
    }
    else if (day == 5)
    {
        Console.WriteLine("пятница");
    }
    else if (day == 6)
    {
        Console.WriteLine("суббота");
    }
    else if (day == 7)
    {
        Console.WriteLine("воскресенье");
    }

}

DayOfTheWeek(day);