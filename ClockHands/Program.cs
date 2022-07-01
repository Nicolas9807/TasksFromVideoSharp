string[] text = Console.ReadLine().Split();

double H = double.Parse(text[0]);
double M = double.Parse(text[1]);

double h = 30 * H + M / 2;
double m = M * 6;
double grad1 = Math.Abs(m - h);
double grad2 = Math.Abs(m - h + 360);
double grad3 = Math.Abs(m - h - 360);
double grad4 = Math.Abs(m - h + 720);
double grad5 = Math.Abs(m - h - 720);

double answer = Math.Min(grad1,grad2);
double answer1 = Math.Min(answer, grad3);
double answer2 = Math.Min(answer1, grad4);
double answer3 = Math.Min(answer2, grad5);
double ans = Math.Min(answer2, answer3);

Console.WriteLine("{0:0.0}", ans);