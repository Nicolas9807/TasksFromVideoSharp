double[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);

double a = arr[0];
double b = arr[1];

double result = -1 * b / a;
Console.WriteLine("{0:0.0}", result);