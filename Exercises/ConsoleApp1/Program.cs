int Quanity = int.Parse(Console.ReadLine()); // Християн

Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

int bigOrder = 0;

while (orders.Count > 0)
{
    int curOrder = orders.Peek();

    if (Quanity >= curOrder)
    {
        Quanity -= curOrder;
        bigOrder = Math.Max(bigOrder, curOrder);
        orders.Dequeue();
    }
    else
    {
        break;
    }
}

if (orders.Count == 0)
{
    Console.WriteLine(bigOrder);
    Console.WriteLine("All orders are completed");
}
else
{
    Console.WriteLine(bigOrder);
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}




