char[] number = Console.ReadLine().ToCharArray();

if (Convert.ToInt32(number[0]) + Convert.ToInt32(number[1]) + Convert.ToInt32(number[2]) ==
     Convert.ToInt32(number[3]) + Convert.ToInt32(number[4]) + Convert.ToInt32(number[5]))
    Console.WriteLine("Happy");
else
    Console.WriteLine("Regular");