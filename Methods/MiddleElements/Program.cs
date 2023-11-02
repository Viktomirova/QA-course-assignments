int[] array = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
double sum = SumMiddleElements(array);
Console.WriteLine($"{sum:F2}");

static double SumMiddleElements(int[] array)
{
    return ((double)array[array.Length / 2 - 1] + array[array.Length / 2]) / 2;
}