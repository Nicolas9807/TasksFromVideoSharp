DateTime min = DateTime.MinValue;
DateTime max = DateTime.MaxValue;
Console.WriteLine(min.ToString("G", System.Globalization.CultureInfo.CreateSpecificCulture("lv")));
Console.WriteLine(max.ToString("G", System.Globalization.CultureInfo.CreateSpecificCulture("lv")));