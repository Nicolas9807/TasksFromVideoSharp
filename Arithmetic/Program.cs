string line = Console.ReadLine();

int pos1 = line.IndexOf('*');
int pos2 = line.IndexOf('=');

long a = long.Parse(line.Substring(0, pos1));
long b = long.Parse(line.Substring(pos1 + 1, pos2 - pos1 - 1));

Console.WriteLine(a*b);
