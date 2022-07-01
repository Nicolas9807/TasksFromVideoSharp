double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToDouble);

double result = Math.Sqrt(Math.Abs(arr[0] * arr[1]));

Console.WriteLine("{0:0.00}",result);
