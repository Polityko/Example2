int rand = new Random().Next(100,999);
Console.WriteLine(rand);

int digit_second = rand % 100 / 10;

Console.WriteLine(digit_second);
