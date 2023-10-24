int n = int.Parse(Console.ReadLine());
int[] firstArr = new int[n];
int[] secondArr = new int[n];

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArr[i] = input[0];
        secondArr[i] = input[1];
    }
    else
    {
        secondArr[i] = input[0];
        firstArr[i] = input[1];
    }
}

Console.WriteLine(String.Join(" ", firstArr));
Console.WriteLine(String.Join(" ", secondArr));