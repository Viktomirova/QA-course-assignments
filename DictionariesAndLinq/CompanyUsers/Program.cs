Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

while (true)
{
    string[] input = Console.ReadLine().Split(" -> ");

    if (input[0] == "End")
    {
        break;
    }

    string company = input[0];
    string employee = input[1];

    if (!data.ContainsKey(company))
    {
        data.Add(company, new List<string>());
        data[company].Add(employee);
    }
    else if (!data[company].Contains(employee))
    {
        data[company].Add(employee);
    }
}

foreach (var company in data)
{
    Console.WriteLine($"{company.Key}");

    foreach (var employee in company.Value)
    {
        Console.WriteLine($"-- {employee}");
    }
}