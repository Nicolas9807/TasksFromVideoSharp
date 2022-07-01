string line = Console.ReadLine();

int indx1 = line.IndexOf('(');
int indx2 = line.IndexOf(')');

line = line.Substring(indx1 + 1, indx2 - indx1 - 1);
Console.WriteLine(line);