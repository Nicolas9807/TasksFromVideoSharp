DateTime date = DateTime.Parse(Console.ReadLine());

int days = DateTime.DaysInMonth(date.Year, date.Month);
if (days == date.Day)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}