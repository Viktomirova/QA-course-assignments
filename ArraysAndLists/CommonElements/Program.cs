int[] firstArray = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] secondArray = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
for (int i = 0; i < firstArray.Length; i++)
{
    if (secondArray.Contains(firstArray[i]))
    {
        Console.Write($"{firstArray[i]} ");
    }
}
