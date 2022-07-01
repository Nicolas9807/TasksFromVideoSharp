int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

int xA = arr[0];
int yA = arr[1];
int xB = arr[2];
int yB = arr[3];

int result = (xB - xA) * (yB - yA);
Console.WriteLine(result);