string line = Console.ReadLine();

bool start = line.ToUpper().StartsWith("HELLO");
bool end = line.EndsWith(".");

Console.WriteLine(start);
Console.WriteLine(end);