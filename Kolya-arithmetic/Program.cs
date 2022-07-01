string[] line = Console.ReadLine().Split(' ');
int a = int.Parse(line[0]);
int b = int.Parse(line[1]);

int sum = a + b;
int sub = a - b;
int mul = a * b;
int div = a / b;
int modulo = a % b;

Console.WriteLine(a + " + " + b + " = " + sum);
Console.WriteLine(a + " - " + b + " = " + sub);
Console.WriteLine(a + " x " + b + " = " + mul);
Console.WriteLine(a + " : " + b + " = " + div + " (" + modulo + ")");