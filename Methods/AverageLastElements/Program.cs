int[] array = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .Reverse()
                   .ToArray();

int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetAverage(array, number):F2}");

static double GetAverage(int[] arr, int num)
{
    double sum = 0;

    for (int i = 0; i < num; i++)
    {
        sum += arr[i];
    }

    return sum / num;
}