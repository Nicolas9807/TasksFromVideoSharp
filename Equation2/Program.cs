double[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);

double x1 = arr[0];
double c = arr[1];

double x2 = c / x1;
double b = -1 * (x1 + x2);

Console.WriteLine("{0:0.0} {1:0.0}", x2, b);