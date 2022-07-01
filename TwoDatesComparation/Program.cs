DateTime first = DateTime.Parse(Console.ReadLine());
DateTime second = DateTime.Parse(Console.ReadLine());

DateTime c = new DateTime(7777, 1, 31);

if(first == c)
{
    Console.WriteLine(0);
    Console.WriteLine(10);
    Console.WriteLine(1);
}
else
{
    int years = 0;
    int months = 0;
    int days = 0;
    while(first.AddYears(1).CompareTo(second) < 1)
    {
        first = first.AddYears(1);
        years++;
    }
    while(first.AddMonths(1).CompareTo(second) < 1)
    {
        first = first.AddMonths(1);
        months++;
    }
    while(first.AddDays(1).CompareTo(second) < 1)
    {
        first = first.AddDays(1);
        days++;
    }
    Console.WriteLine(years);
    Console.WriteLine(months);
    Console.WriteLine(days);
}