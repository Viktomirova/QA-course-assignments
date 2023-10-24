int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

while (numbers.Length > 1)
{
    int[] temp = new int[numbers.Length - 1];

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = numbers[i] + numbers[i + 1];
    }

    numbers = temp;
}

Console.WriteLine(numbers[0]);