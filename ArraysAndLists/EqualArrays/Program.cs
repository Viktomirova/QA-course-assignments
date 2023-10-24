int[] firstArray = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] secondArray = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
bool isEqual = false;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] == secondArray[i])
    {
        isEqual = true;
    }
    else
    {
        isEqual = false;
        Console.WriteLine("Arrays are not identical.");
        return;
    }

}
if (isEqual)
{
    Console.WriteLine("Arrays are identical.");
}