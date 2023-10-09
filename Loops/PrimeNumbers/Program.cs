int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
if (start < 1) return;
for (int i = start; i <= end; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime == true) Console.Write($"{i} ");
}