int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int topNumber = numbers[i];
    bool isTopNumber = true;

    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] >= topNumber)
        {
            isTopNumber = false;
            break;
        }
    }

    if (isTopNumber == true)
    {
        Console.Write($"{topNumber} ");
    }
}