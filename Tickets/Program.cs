int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int res6 = 0;
int res5 = 0;
int res4 = 0;
int res3 = 0;
int res2 = 0;
int res1 = 0;
int a6 = a % 10;
int b6 = b % 10;
int a5 = (a / 10) % 10;
int b5 = (b / 10) % 10;
int a4 = (a / 100) % 10;
int b4 = (b / 100) % 10;
int a3 = (a / 1000) % 10;
int b3 = (b / 1000) % 10;
int a2 = (a / 10000) % 10;
int b2 = (b / 10000) % 10;
int a1 = (a / 100000) % 10;
int b1 = (b / 100000) % 10;
if (a6 > b6)
{
    res6 = a6 - b6;
}
else
{
    res6 = b6 - a6;
}

if (a5 > b5)
{
    res5 = a5 - b5;
}
else
{
    res5 = b5 - a5;
}

if (a4 > b4)
{
    res4 = a4 - b4;
}
else
{
    res4 = b4 - a4;
}

if (a3 > b3)
{
    res3 = a3 - b3;
}
else
{
    res3 = b3 - a3;
}

if (a2 > b2)
{
    res2 = a2 - b2;
}
else
{
    res2 = b2 - a2;
}

if (a1 > b1)
{
    res1 = a1 - b1;
}
else
{
    res1 = b1 - a1;
}

int result = res1 + res2 + res3 + res4 + res5 + res6;
Console.WriteLine(result);