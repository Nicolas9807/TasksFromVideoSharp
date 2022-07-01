int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int count = 0;

for (int i = a; i <= b; i++)
{
    if (DateTime.IsLeapYear(i))
    {
        count++;
    }
}

Console.WriteLine(count);