DateTime ticks = new DateTime(long.Parse(Console.ReadLine()));
string[] date = Console.ReadLine().Split();

int year = int.Parse(date[0]);
int month = int.Parse(date[1]);
int day = int.Parse(date[2]);
int hour = int.Parse(date[3]);
int minute = int.Parse(date[4]);
int second = int.Parse(date[5]);
int milisecond = int.Parse(date[6]);

DateTime dt = new DateTime(year, month, day, hour, minute, second, milisecond);

string result = ticks.CompareTo(dt).ToString();

Console.WriteLine(result);