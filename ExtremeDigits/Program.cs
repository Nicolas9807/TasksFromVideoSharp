int number = int.Parse(Console.ReadLine());

int result = (number % 10) * 1000 + ((number/10) % 100) * 10 + number / 1000;

Console.WriteLine(result);