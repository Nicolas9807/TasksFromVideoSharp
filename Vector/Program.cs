double length = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(length, 2) - Math.Pow(x, 2));
Console.WriteLine("{0:0.00}",result);