DateTime first = DateTime.Parse(Console.ReadLine());
DateTime second = DateTime.Parse(Console.ReadLine());

TimeSpan a = first.Subtract(second).Duration();

string res1 = a.TotalDays.ToString();
string res2 = a.TotalHours.ToString();
string res3 = a.TotalMinutes.ToString();

string result = res1 + " " + res2 + " " + res3;

Console.WriteLine(result);