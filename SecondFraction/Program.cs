double number = double.Parse(Console.ReadLine()) * 100;

int result = (int)Math.Abs(number % 10);

Console.WriteLine("{0:0}", result);