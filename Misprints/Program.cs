string[] numbers = Console.ReadLine().Split(' ');
int bytes = int.Parse(numbers[0]) * 1024;
int mistake = int.Parse(numbers[1]) * 2;

Console.WriteLine(bytes + mistake);