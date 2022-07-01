string line = Console.ReadLine();
DateTime date;
string result;

if (DateTime.TryParse(line, out date))
{
    date = DateTime.Parse(line);
    result = date.DayOfYear.ToString();
}

else
{
    result = "-1";
}

Console.WriteLine(result);