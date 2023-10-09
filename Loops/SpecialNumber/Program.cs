int number = int.Parse(Console.ReadLine());
int num = number;
while (num > 0)
{
    int digit = num % 10;
    if (number % digit != 0)
    {
        Console.WriteLine($"{number} is not special");
        return;
    }
    num /= 10;
}
Console.WriteLine($"{number} is special");