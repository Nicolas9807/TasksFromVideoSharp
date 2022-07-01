long x = long.Parse(Console.ReadLine());

while(x>9)
{
    x = x / 10 + x % 10;
}

Console.WriteLine(x);