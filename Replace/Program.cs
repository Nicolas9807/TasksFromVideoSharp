string line = Console.ReadLine();
      
line = line.Replace('A', '~').Replace('O', 'A').Replace('~', 'O');
line = line.Replace('a', '~').Replace('o', 'a').Replace('~', 'o');
Console.WriteLine(line);