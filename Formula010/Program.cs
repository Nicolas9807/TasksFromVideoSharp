double a = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = Math.Pow(x * x * x, 1f/4f) + a * x;
double znam = Math.Log(Math.Sqrt(a * a + Math.Sqrt(x)));
double result = chis / znam;
Console.WriteLine("{0:0.0000}",result);