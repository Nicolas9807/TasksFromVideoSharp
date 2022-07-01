int count = int.Parse(Console.ReadLine());
string[] names = new string[count];
DateTime[] dates = new DateTime[count];

for (int i = 0; i < count; i++)
{
    names[i] = Console.ReadLine();
    dates[i] = DateTime.Parse(Console.ReadLine());
}

Array.Sort(dates, names);

for (int i = 0; i < count; i++)
{
    Console.WriteLine(names[i]);
}