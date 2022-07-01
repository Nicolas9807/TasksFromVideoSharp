string[] code = Console.ReadLine().Split();

for (int i = 0; i < 7; i++)
{
    Console.Write((char)int.Parse(code[i]));
}

Console.WriteLine();