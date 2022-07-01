double a = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = Math.Pow(a * x, 1f/3f); 
double znam = a + x * Math.Log10(a + x);
double result = chis / znam;
Console.WriteLine("{0:0.00000}",result);