double a = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = Math.Pow(Math.Abs(a - x * x) * Math.Log(a + x), 1f / 3f);
double znam = Math.Pow(x * x, 1f / 3f) + Math.Pow(a, 1f / 5f);
double result = chis / znam;
Console.WriteLine("{0:0.00}",result);