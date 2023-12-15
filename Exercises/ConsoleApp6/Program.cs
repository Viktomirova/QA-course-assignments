int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x))
    .ToArray();

int stackDimension = input[0];
int elementsToPop = input[1];
int numberToFind = input[2];


int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x))
    .ToArray();

CreateStack(stackDimension, numbers);

Stack<int> stack = new Stack<int>(numbers);

FindElement(stack, numberToFind);
PrintMinOrNothing(stack);

void PrintMinOrNothing(Stack<int> stack)
{
    if (stack.Count > 0)
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine("nothing found");
    }

}

void FindElement(Stack<int> stack, int elementsToPop)
{
    for (int i = 0; i < elementsToPop; i++)
    {
        stack.Pop();
    }
}
static Stack<int> CreateStack(int dimention, int[] numb)
{
    Stack<int> stack = new Stack<int>();
    for (int i = 0; i < dimention; i++)
    {
        stack.Push(numb[i]);
    }
    return stack;
}
