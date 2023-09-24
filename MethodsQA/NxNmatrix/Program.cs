int n = int.Parse(Console.ReadLine());
PrintMatrix(n);
static void PrintMatrix(int n)
{
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}