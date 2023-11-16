using System.Text;

List<string> collection = Console.ReadLine()
                                 .Split()
                                 .Select(x => x.ToLower())
                                 .ToList();
Dictionary<string, int> newDictionary = new Dictionary<string, int>();

foreach (string item in collection)
{
    if (newDictionary.ContainsKey(item))
    {
        newDictionary[item] ++;
    }
    else
    {
        newDictionary.Add(item, 1);
    }
}

foreach (KeyValuePair<string, int> kvp in newDictionary.Where(x => x.Value % 2 != 0))
{
    Console.Write($"{kvp.Key} ");
}