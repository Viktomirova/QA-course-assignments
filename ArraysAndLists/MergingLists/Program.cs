
List<int> firstList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> secondList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
if (firstList.Count > secondList.Count)
{
    PrintMix(secondList.Count, firstList, secondList);
    PrintDiff(secondList.Count, firstList);
}
else
{
    PrintMix(firstList.Count, firstList, secondList);
    PrintDiff(firstList.Count, secondList);
}

static void PrintDiff(int start, List<int> list)
{
    for (int i = start; i < list.Count; i++)
    {
        Console.Write(list[i] + " ");
    }
}
static void PrintMix(int count, List<int> first, List<int> second)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(first[i] + " " + second[i] + " ");
    }
}