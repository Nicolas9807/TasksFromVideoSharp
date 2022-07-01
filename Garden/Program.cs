string[] line = Console.ReadLine().Split();

int area = int.Parse(line[0]) * 100;
int width = int.Parse(line[1]);

double result = 2 * width + 2 * (area / width);
Console.WriteLine(result);