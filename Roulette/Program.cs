Random rand = new Random();
int n = int.Parse(Console.ReadLine());
int a;
switch (n)
{
    case 1: a = 1; break;
    case 3: a = 2; break;
    case 4: a = 2; break;
    case 5: a = 3; break;
    case 6: a = 5; break;
    case 10:
        if  (rand.Next(0, 2) == 0)
            a = 10;
        else
            a = rand.Next(1, 10);
        break;
    default: a = 0; break;             
}
Console.WriteLine(a);