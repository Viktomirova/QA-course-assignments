Dictionary<string, int> resourses = new Dictionary<string, int>();
while (true)
{
    string resourse = Console.ReadLine();

    if (resourse == "stop")
    {
        break;
    }

    int quantity = int.Parse(Console.ReadLine());

    if (resourses.ContainsKey(resourse))
    {
        resourses[resourse] += quantity;
    }
    else
    {
        resourses.Add(resourse, quantity);
    }
}

foreach (KeyValuePair<string, int> kvp in resourses)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}