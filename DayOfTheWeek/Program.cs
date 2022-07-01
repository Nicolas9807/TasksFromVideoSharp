int year = int.Parse(Console.ReadLine());
int month = int.Parse(Console.ReadLine());
int day = int.Parse(Console.ReadLine());

DateTime date = new DateTime(year,month,day);

string result = date.DayOfWeek.ToString();

Console.WriteLine(result);