string line = Console.ReadLine().ToLower();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(line.Contains(Console.ReadLine().ToLower()));
}