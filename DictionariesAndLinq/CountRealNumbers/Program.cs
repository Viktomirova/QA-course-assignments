List<int> numbers = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();
Dictionary<int, int> numDictionary = new Dictionary<int, int>();
foreach (int number in numbers)
{
    if (numDictionary.ContainsKey(number))
    {
        numDictionary[number] ++;
    }
    else
    {
        numDictionary.Add(number, 1);
    }
}

foreach (KeyValuePair<int, int> kvp in numDictionary.OrderBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}