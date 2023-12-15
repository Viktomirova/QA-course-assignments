int food = int.Parse(Console.ReadLine());

Queue<int> orders = new Queue<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

int biggestOrder = 0;

while (orders.Count > 0 && food >= orders.Peek())
{
    int currentOrder = orders.Dequeue();
    biggestOrder = Math.Max(biggestOrder, currentOrder);
    food -= currentOrder;
}

Console.WriteLine(biggestOrder);

if (orders.Count == 0)
{
    Console.WriteLine("All orders are completed");
}
else
{
    Console.Write("Orders left: ");
    Console.WriteLine(String.Join(" ", orders));
}
