char line = Char.Parse(Console.ReadLine());
byte firstSymbol = (byte)line;

for (int i = 0; i < 6; i++)
{
    Console.Write("{0}", (char)firstSymbol + " ");
    firstSymbol++;
}

Console.WriteLine();