double a = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = Math.Pow(a * x, 2) * Math.Pow(1/Math.Pow(a + x, 2), 1f/3f); 
double znam = a * Math.Log(a + Math.Pow(x, 2));
double result = chis / znam;
Console.WriteLine("{0:0.000000}",result);