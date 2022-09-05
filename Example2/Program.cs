int rand = new Random().Next(1,65536);
Console.WriteLine(rand);

if (rand < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (rand > 100);
    int digit_3 = (rand / 100) % 10;
    Console.WriteLine(digit_3);
}