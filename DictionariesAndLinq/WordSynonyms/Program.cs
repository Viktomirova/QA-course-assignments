Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();
    if (!words.ContainsKey(word))
    {
        words.Add(word, new List<string>());
        words[word].Add(synonym);
    }
    else
    {
        words[word].Add(synonym);
    }
}

foreach (KeyValuePair<string, List<string>> kvp in words)
{
    Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
}