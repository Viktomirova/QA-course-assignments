int number = 0;
while (number < 1 || number > 100)
{
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine(number);