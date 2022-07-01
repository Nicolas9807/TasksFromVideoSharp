string line = Console.ReadLine();
string word = Console.ReadLine();

int indx1 = line.IndexOf('(');
int indx2 = line.IndexOf(')');

line = line.Remove(indx1 + 1, indx2 - indx1 - 1);

line = line.Insert(indx1 + 1, word);
Console.WriteLine(line);
