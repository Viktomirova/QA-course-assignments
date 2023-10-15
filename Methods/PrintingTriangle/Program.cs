int n = int.Parse(Console.ReadLine());
PrintTriangle(n);
static void PrintTriangle(int n)
{
    for (int row = 1; row <= n; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
    for (int row = n; row >= 1; row--)
    {
        for (int col = 1; col < row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
}