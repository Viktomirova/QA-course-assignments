int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine(Subtractor(firstNumber, secondNumber, thirdNumber));

static int Summator (int x, int y)
{
    int sum = x + y;
    return sum;
}

static int Subtractor (int a, int b, int c)
{
    int sum = Summator(a, b);
    int result = sum - c;
    return result;
}