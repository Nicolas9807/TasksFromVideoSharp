int[] A = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
int[] B = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
int[] C = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

int xA = A[0];
int yA = A[1];
int xB = B[0];
int yB = B[1];
int xC = C[0];
int yC = C[1];

double AB = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
double BC = Math.Sqrt(Math.Pow(xB - xC, 2) + Math.Pow(yB - yC, 2));
double AC = Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2));

double result = AB + BC + AC;

Console.WriteLine("{0:0.00}", result);