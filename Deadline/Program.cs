DateTime start = DateTime.Parse(Console.ReadLine());
DateTime finish = DateTime.Parse(Console.ReadLine());
DateTime end = DateTime.Parse(Console.ReadLine());

string[] money = Console.ReadLine().Split();
int salary = int.Parse(money[0]);
int fine = int.Parse(money[1]);
int income = salary * (finish.Subtract(start).Days + 1) - fine * (end.Subtract(finish).Days);
int result;
if (income > 0)
{
    result = income;
}
else
{
    result = 0;
}

Console.WriteLine(result);