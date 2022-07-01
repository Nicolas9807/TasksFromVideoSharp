double[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);

double a = arr[0];
double b = arr[1];

double result = Math.Abs(a * b / 2);

Console.WriteLine("{0:0.00}", result);