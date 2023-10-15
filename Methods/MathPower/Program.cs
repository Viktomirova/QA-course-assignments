int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateMathPower(baseNumber, power));

static double CalculateMathPower(int n, int p)
{
    double result = Math.Pow(n, p);
    return result;
}