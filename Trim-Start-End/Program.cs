string line = Console.ReadLine();
line = line.Trim('[', ']');
Console.WriteLine(line.TrimStart(' ', '\t').Insert(0, "[") + "]");
Console.WriteLine(line.TrimEnd(' ', '\t').Insert(0, "[") + "]");
Console.WriteLine(line.TrimStart(' ', '\t').TrimEnd(' ', '\t').Insert(0, "[") + "]");