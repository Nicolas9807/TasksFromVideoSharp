int N = int.Parse(Console.ReadLine());
string[] users = new string[N];
DateTime[] dates = new DateTime[N];

for(int i = 0; i < N; i++)
{
    users[i] = Console.ReadLine();
    dates[i] = DateTime.Parse(Console.ReadLine());
}

int n1 = 0, n2 = 1;
TimeSpan tempSpan = dates[0].Subtract(dates[1]).Duration();
for(int i = 0; i < N-1; i++)
{
    for(int j = i+1; j < N; j++)
    {
        TimeSpan currentSpan = dates[i].Subtract(dates[j]).Duration();
        if(TimeSpan.Compare(currentSpan, tempSpan) < 0)
        {
            tempSpan = currentSpan;
            n1 = i;
            n2 = j;
        }
    }
}
Console.WriteLine("{0} {1}", users[n1], users[n2]);