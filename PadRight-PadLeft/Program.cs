string[] array = new string[7];

for (int i = 0; i < 7; i++)
{
    array[i] = Console.ReadLine();
}

for (int i = 0; i < 7; i++)
{
    Console.WriteLine(array[i].PadRight(8) + array[i].PadLeft(8));
}
