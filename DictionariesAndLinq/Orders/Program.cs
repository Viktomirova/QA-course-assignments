Dictionary<string, Dictionary<double, int>> orders = new Dictionary<string, Dictionary<double, int>>();
while (true)
{
    string[] order = Console.ReadLine().Split();
    string product = order[0];

    if (product == "buy")
    {
        break;
    }

    double price = double.Parse(order[1]);
    int quantity = int.Parse(order[2]);

    if (orders.ContainsKey(product))
    {
    }
    else
    {
        orders.Add(product, new Dictionary<double, int>());
    }
}

foreach (KeyValuePair<string, Dictionary<double, int>> kvp in orders)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
}