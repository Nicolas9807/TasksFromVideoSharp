int Г = int.Parse(Console.ReadLine()); // города
int Д = int.Parse(Console.ReadLine()); // дома
int Э = int.Parse(Console.ReadLine()); // этажи
int П = int.Parse(Console.ReadLine()); // подъездов
int К = int.Parse(Console.ReadLine()); // квартир
int О = int.Parse(Console.ReadLine()); // окон
int М = int.Parse(Console.ReadLine()); // мурзиков
int домов = Г * Д;
int квартир = Г * Д * Э * П * К;
int окон = Г * Д * Э * П * К * О;
int мурзиков = Г * Д * М;
Console.WriteLine(домов);
Console.WriteLine(квартир);
Console.WriteLine(окон);
Console.WriteLine(мурзиков);