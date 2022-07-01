int year = int.Parse(Console.ReadLine());

DateTime date = new DateTime(year, 1, 1);

string result = date.AddDays(255).ToString("dd.MM.yyyy");

Console.WriteLine(result);