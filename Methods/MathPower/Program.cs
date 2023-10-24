int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateMathPower(baseNumber, power));

static double CalculateMathPower(int n, int p)
{
    double result = 1;
    for (int i = 1; i <= p; i++)
    {
        result *= n;
    }
    return result;
}