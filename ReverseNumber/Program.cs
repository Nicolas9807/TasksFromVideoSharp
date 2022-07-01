char[] numbers = Console.ReadLine().ToCharArray();

for(int i = numbers.Length - 1; i >= 0; i--){
    if (numbers[i] != '0')
    {
        Console.Write(numbers[i]);
    }
}

Console.WriteLine();

