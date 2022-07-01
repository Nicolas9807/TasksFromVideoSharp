int count = int.Parse(Console.ReadLine());
int minutes = count * 55 - 10;
count = 8;
       
while(minutes >= 60)
{
    minutes -= 60;
    count++;
    if (count == 24)
        count = 0;
}
       
if (minutes < 0)
    minutes = 0;
       
Console.WriteLine("{0:00}:{1:00}", count, minutes);