int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

int a = arr[0];
int b = arr[1];
int c = arr[2];

long result = b * b - 4 * a * c;

Console.WriteLine("{0:0}", result);