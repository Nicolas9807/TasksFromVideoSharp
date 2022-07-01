double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double i = Math.Pow(a + b, 2); 
double j = Math.Sqrt((a + x) / (b + x));
double k = Math.Log(a + x);
double result = i * j * k;
Console.WriteLine("{0:0.0000}",result);