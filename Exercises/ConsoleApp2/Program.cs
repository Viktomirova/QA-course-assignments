using System;

int x, y, z;

string[] input = Console.ReadLine().Split();
x = int.Parse(input[0]);
y = int.Parse(input[1]);
z = int.Parse(input[2]);

string[] elementsInput = Console.ReadLine().Split();
int[] elements = new int[elementsInput.Length];

for (int i = 0; i < elementsInput.Length; i++)
{
    elements[i] = int.Parse(elementsInput[i]);
}

PerformStackOperations(x, y, z, elements);

static void PerformStackOperations(int x, int y, int z, int[] elements)
{
    Stack<int> stack = new Stack<int>();

    for (int i = 0; i < x; i++)
    {
        stack.Push(elements[i]);
    }

    for (int i = 0; i < y && stack.Count > 0; i++)
    {
        stack.Pop();
    }

    if (stack.Contains(z))
    {
        Console.WriteLine("found");
    }
    else
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
}
