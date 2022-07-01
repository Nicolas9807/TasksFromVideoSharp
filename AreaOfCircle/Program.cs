double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);

double xO = arr[0];
double yO = arr[1];
double xB = arr[2];
double yB = arr[3];

double x = Math.Pow(xB - xO, 2);
double y = Math.Pow(yB - yO, 2);

double r = Math.Sqrt(x + y);

double result = Math.PI * Math.Pow(r, 2);

Console.WriteLine("{0:0.00}",result);