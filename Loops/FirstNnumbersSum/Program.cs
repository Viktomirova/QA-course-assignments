int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
    if (i == n)
    Console.Write($"{i}=");
    else
    Console.Write($"{i}+");
    sum += i;
}
Console.WriteLine(sum);