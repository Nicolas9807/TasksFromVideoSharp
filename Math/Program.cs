double x = double.Parse(Console.ReadLine());
       
Console.WriteLine("{0:f3}", Math.Abs(x));
Console.WriteLine("{0:f3}", Math.Sin(x));
Console.WriteLine("{0:f3}", Math.Cos(x));
Console.WriteLine("{0:f3}", Math.PI * x);
Console.WriteLine("{0:f3}", Math.Pow(x, 2));
Console.WriteLine("{0:f3}", Math.Sqrt(x));
Console.WriteLine("{0:f3}", Math.Log(x));
Console.WriteLine("{0:f3}", Math.Log10(x));
Console.WriteLine("{0:f3}", Math.Exp(x));
Console.WriteLine("{0:f3}", Math.Pow(x, Math.Exp(1)));