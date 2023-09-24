double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"{FactorialDivision(a, b):F2}");
static double FactorialDivision(double a, double b)
{
    double n = a;
    double m = b;
    for (int i = 1; i < n; i++)
    {
        a *= i;
    }
    for (int i = 1; i < m; i++)
    {
        b *= i;
    }
    return a / b;
}
