int number = int.Parse(Console.ReadLine());

int result = (number / 1000) * 100 + (number % 100);

Console.WriteLine(result);