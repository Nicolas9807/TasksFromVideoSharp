string[] chislo = Console.ReadLine().Split('.');
int year = int.Parse(chislo[0]);
int month = int.Parse(chislo[1]);
Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
DateTime date = new DateTime(year, month, 1);
int lenght = DateTime.DaysInMonth(year, month);
int day = (int)date.DayOfWeek;
if (day == 0) day = 7;
day --;

if (year == 1752 && month == 9)
{
    Console.WriteLine("      1   2  14  15  16  17");
    Console.WriteLine(" 18  19  20  21  22  23  24");
    Console.WriteLine(" 25  26  27  28  29  30");
}
else
{
    for (int i = 0; i < day; i++)
        Console.Write("    ");
    for (int i = 1; i <= lenght; i++)
    {
        int d = (day + i - 1) % 7;
        if (d < 6 && i != lenght)                   
            Console.Write("{0,3} ", i);                   
        else                   
            Console.WriteLine("{0,3}", i);                   
    }
}

Console.WriteLine();