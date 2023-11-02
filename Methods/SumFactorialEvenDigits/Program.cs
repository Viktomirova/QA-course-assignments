using System.Runtime.CompilerServices;

//int n = int.Parse((Console.ReadLine()));
//int sum = 0;

//while (n != 0)
//{
//    int a = n % 10;

//    if (a % 2 == 0)
//    {
//        sum += CalculateFactoriel(a);
//    }

//    n /= 10;
//}

//Console.WriteLine(sum);


Console.WriteLine(Console.ReadLine()
                         .ToCharArray()
                         .Select(s => int.Parse(s.ToString()))
                         .Where(n => n % 2 == 0)
                         .Select(x => CalculateFactoriel(x))
                         .ToArray()
                         .Sum());

static int CalculateFactoriel(int n)
{
    int a = 1;
    for (int i = 1; i <= n; i++) a *= i;
    return a;
}