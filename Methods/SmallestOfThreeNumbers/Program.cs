static int GetSmallestNumber()
{
    int smallest = int.MaxValue;

    for (int i = 0; i < 3; i++)
    {
        int input = int.Parse(Console.ReadLine());
        if (smallest > input)
            smallest = input;
    }

    return smallest;
}
Console.WriteLine(GetSmallestNumber());
