int rand = new Random().Next(1,1000000);
Console.WriteLine(rand);



if (rand % 7 == 0 && rand % 23 == 0)

{ 
    Console.WriteLine ("Кратное число");
}
else
{
    Console.WriteLine ("Некратное число");
}