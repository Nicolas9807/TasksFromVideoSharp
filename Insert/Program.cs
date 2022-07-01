string line = Console.ReadLine();
string word = Console.ReadLine();

int indx = line.IndexOf(' ');
string final = line.Insert(indx, " " + word);

Console.WriteLine(final);