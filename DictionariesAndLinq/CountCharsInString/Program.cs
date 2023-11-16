char[] text = Console.ReadLine().ToCharArray();
Dictionary<char, int> charDictionary = new Dictionary<char, int>();
foreach (char ch in text)
{
    if (ch == ' ')
    {
        continue;
    }
    if (!charDictionary.ContainsKey(ch))
    {
        charDictionary.Add(ch, 1);
    }
    else
    {
        charDictionary[ch]++;
    }
}

foreach (KeyValuePair<char, int> kvp in charDictionary)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}