int dimentionOfMatrix = int.Parse(Console.ReadLine());
int[,] matrix = new int[dimentionOfMatrix, dimentionOfMatrix];
int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = input[col];
        if (row == col)
        {
            sum += matrix[row, col];
        }
    }
}

Console.WriteLine(sum);