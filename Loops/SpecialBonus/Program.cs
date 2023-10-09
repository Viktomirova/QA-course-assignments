int stopNumber = int.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine());

while (true)
{
    int previousNumber = number;
    number = int.Parse(Console.ReadLine());
    if (stopNumber == number)
    {
        double result = previousNumber * 1.2;

        Console.WriteLine(result);
        break;
    }
}