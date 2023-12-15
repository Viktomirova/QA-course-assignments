string[] input = Console.ReadLine().Split();

Stack<string> collection = new Stack<string>(input.Reverse());//2 + 5 + 10 - 2 - 1

while (collection.Count > 1)
{
    int number1 = int.Parse(collection.Pop());
    string operand = collection.Pop();
    int number2 = int.Parse(collection.Pop());
    switch (operand)
    {
        case "+":
        collection.Push((number1 + number2).ToString());
        break;
        case "-":
        collection.Push((number1 - number2).ToString());
        break;

    }
}
Console.WriteLine(collection.Pop());