string line = Console.ReadLine();

int indexPlus = line.IndexOf('+');
int indexMul = line.IndexOf('*');
int indexEq = line.IndexOf('=');

int a = int.Parse(line.Substring(0, indexPlus));
int b = int.Parse(line.Substring(indexPlus + 1, indexMul - indexPlus - 1));
int c = int.Parse(line.Substring(indexMul + 1, indexEq - indexMul - 1));

int result = a + b * c; 

Console.WriteLine(result);