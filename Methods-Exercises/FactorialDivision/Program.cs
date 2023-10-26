int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"{CalculateFactoriel(firstNumber) / CalculateFactoriel(secondNumber):F2}");

static decimal CalculateFactoriel (int num)
{
    long result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}