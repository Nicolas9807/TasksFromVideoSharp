double a = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());

double chis = a + Math.Sqrt(a * x); 
double znam = Math.Sqrt(a) + Math.Log(a + x);
double result = chis / znam;
Console.WriteLine("{0:0.000000}",result);