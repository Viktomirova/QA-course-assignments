int n = int.Parse(Console.ReadLine());

PrintTheSignOfNumber(n);

static void PrintTheSignOfNumber(int n)
{
    if (n == 0) Console.WriteLine($"The number {n} is zero.");
    else if (n > 0) Console.WriteLine($"The number {n} is positive.");
    else Console.WriteLine($"The number {n} is negative.");
}
