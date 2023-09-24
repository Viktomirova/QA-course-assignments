int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine(Subtractor(firstNumber, secondNumber, thirdNumber));
static int Summator(int a, int b)
{
    int result = a + b;
    return result;
}

static int Subtractor(int a, int b, int c)
{
    int sum = Summator(a, b);
    int result = sum - c;
    return result;
}