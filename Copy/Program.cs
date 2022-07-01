string first = Console.ReadLine();
string second = Console.ReadLine();
string tmp = String.Copy(first);

first = String.Copy(second);
second = String.Copy(tmp);

Console.WriteLine(first);
Console.WriteLine(second);