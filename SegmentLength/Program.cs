double[] A = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);
double[] B = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);

double xA = A[0];
double yA = A[1];
double xB = B[0];
double yB = B[1];

double x = Math.Pow(xB - xA, 2);
double y = Math.Pow(yB - yA, 2);

double result = Math.Sqrt(x + y);

Console.WriteLine("{0:0.00}",result);