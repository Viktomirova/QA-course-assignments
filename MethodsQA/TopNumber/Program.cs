int number = int.Parse(Console.ReadLine());
for (int i = 0; i < number; i++)
{
    CheckNum(i);
}

static void CheckNum(int num)
{
    int sum = 0;
    int topNumber = num;
    bool isTopNumber = false;
    while (topNumber > 0)
    {
        if ((topNumber % 10) % 2 != 0)
        {
            isTopNumber = true;
        }
        sum += topNumber % 10;
        topNumber /= 10;
    }
    if (isTopNumber && sum % 8 == 0)
    {
        Console.WriteLine(num);
    }
}