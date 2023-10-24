int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

CreatePINCode(max1, max2, max3);

static void CreatePINCode(int a, int b, int c)
{
    for (int digit1 = 2; digit1 <= a; digit1 += 2)
    {
        for (int digit2 = 1; digit2 <= b; digit2++)
        {
            for (int digit3 = 2; digit3 <= c; digit3 += 2)
            {
                if (digit2 == 2 || digit2 == 3 || digit2 == 5 || digit2 == 7)
                {
                    Console.WriteLine($"{digit1}{digit2}{digit3}");
                }
            }
        }
    }
}