int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(number)));

static int GetSumOfEvenDigits (int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 == 0)
        {
            sum += digit;
        }
        n /= 10;
    }

    return sum;
}

static int GetSumOfOddDigits (int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        if (digit % 2 != 0)
        {
            sum += digit;
        }
        n /= 10;
    }

    return sum;
}

static int GetMultipleOfEvenAndOdds (int n)
{
    int result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);

    return result;
}

