double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = Math.Abs(a - b * Math.Pow(x, 1f/3f)); 
double znam = b * Math.Log(Math.Abs(a * a + x));
double result = chis / znam;
Console.WriteLine("{0:0.000000}",result);