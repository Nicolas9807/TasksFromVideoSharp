long number = long.Parse(Console.ReadLine());

long s = number % 60;
long m = number / 60 % 60;
long h = number / 3600 % 24;

Console.WriteLine("{0} {1} {2}", h, m, s);