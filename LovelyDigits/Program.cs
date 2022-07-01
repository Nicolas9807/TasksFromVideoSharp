int number = int.Parse(Console.ReadLine());
int sum1 = 0;
while(number > 0) {
    sum1 += number % 10;
    number /= 10;
    if(sum1 > 9) {
        sum1 = sum1 / 10 + sum1 % 10;
    }
}
Console.WriteLine(sum1);