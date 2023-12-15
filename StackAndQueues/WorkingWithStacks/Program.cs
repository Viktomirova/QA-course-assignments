int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var stack = new Stack<int>(numbers);
string[] command = Console.ReadLine()
    .ToLower()
    .Split()
    .ToArray();
while (command[0] != "end")
{
    ManipulateStack(stack);
    command = Console.ReadLine().ToLower().Split().ToArray();
}
Console.WriteLine($"Sum: {stack.Sum()}");


static Stack<int> ManipulateStack( Stack<int> stack)
{
    string[] command = Console.ReadLine().ToLower().Split().ToArray();
    switch (command[0])
    {
        case "add":
        stack.Push(int.Parse(command[1]));
        stack.Push(int.Parse(command[2]));
        break;
        case "remove":
        int toRemove = int.Parse(command[1]);
        if (toRemove <= stack.Count)
        {
            for (int i = 0; i < toRemove; i++)
            {
                stack.Pop();
            }
        }
        break;
    }
    return stack;
}