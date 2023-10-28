int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine(Subtractor(Summator(firstNumber, secondNumber), thirdNumber));

static int Summator (int x, int y)
{
    return x + y;
}

static int Subtractor (int a, int b)
{
    return a - b;
}