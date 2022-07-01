int digits = int.Parse(Console.ReadLine());
int total = 0;
while (digits > 0)
{
    total = total + (digits % 10);
    digits /= 10;
}

Console.WriteLine(total);