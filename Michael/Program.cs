string[] line = Console.ReadLine().Split(' ');
int apples = (int.Parse(line[0]) * 25 + int.Parse(line[1]) * 12 + 5 * 2 + 10 * 5) / 40;
Console.WriteLine(apples);