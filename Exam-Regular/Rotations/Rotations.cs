int[] array = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
        int temp = array[j];
        array[j] = array[array.Length - 1];
        array[array.Length - 1] = temp;
    }
}

Console.WriteLine(String.Join(", ", array));