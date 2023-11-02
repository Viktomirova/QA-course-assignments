using System.Text;

static bool IsPrimeNumber(int number)
{
    while (number > 0)
    {
        int digit = number % 10;
        if (digit <= 1) return false;

        for (int j = 2; j < digit; j++)
        {
            if (digit % j == 0)
            {
                return false;
            }
        }

        number /= 10;

    }
    return true;
}

static bool SumOfDigitsIsDivisibleByTwo(int num)
{
    int sum = 0;

    while (num > 1)
    {
        int digit = num % 10;
        sum += digit;
        num /= 10;
    }

    return sum % 2 == 0 ? true : false;
}

int number = int.Parse(Console.ReadLine());
//Console.WriteLine(SumOfDigitsIsDivisibleByTwo(number));
//Console.WriteLine(IsPrimeNumber(number));

List<int> numbersResult = new List<int>();
for (int i = 2; i <= number; i++)
{
    if (IsPrimeNumber(i))
    {
        numbersResult.Add(i);
    }
}

if (numbersResult.Count > 0)
{
    Console.WriteLine(String.Join(" ", numbersResult.Where(x => SumOfDigitsIsDivisibleByTwo(x))));
}
else
{
    Console.WriteLine("no");
}
