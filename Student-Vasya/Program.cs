string[] text = Console.ReadLine().Split(' ');
int hour = int.Parse(text[0]);
int minute = int.Parse(text[1]);
int inDream = hour * 60 + minute;
int withoutDream = 24 * 60 - inDream;
Console.WriteLine(inDream);
Console.WriteLine(withoutDream);