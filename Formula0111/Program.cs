double a = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = Math.Pow(a, 2) + x * Math.Pow(x, 1f/3f); 
double znam = Math.Sqrt(a) + Math.Pow(x, 1f/3f);
double result = chis / znam;
Console.WriteLine("{0:0.000000}",result);