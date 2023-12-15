int[,] matrix = 
{  { 5, 2, 3, 1 },
   { 1, 9, 2, 4 },
   { 9, 8, 6, 11 }  };
for (int row = 0; row < matrix.GetLength(0); row++)
{
  for (int col = 0; col < matrix.GetLength(1); col++)
  {
    Console.Write(matrix[row, col] + " ");
  }

  Console.Write("; ");
}
Console.WriteLine();
