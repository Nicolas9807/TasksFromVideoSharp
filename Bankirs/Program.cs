string[] line = Console.ReadLine().Split();

long a = long.Parse(line[0]);
long b  = long.Parse(line[1]);

Console.WriteLine("{0} {1}", a+b, a*b);