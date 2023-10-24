int n = int.Parse(Console.ReadLine());

ValidatePassword(n);

static void ValidatePassword(int n)
{
    for (int num1 = 2; num1 <= n; num1 += 2)
    {
        for (int num2 = 1; num2 <= n; num2 += 2)
        {
            Console.Write($"{num1}{num2}{num1 * num2} ");
        }
    }
}