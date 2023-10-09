int n = int.Parse(Console.ReadLine());
int divisibleBy2 = 0;
int divisibleBy3 = 0;
int divisibleBy4 = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num % 2 == 0) divisibleBy2++;
    if (num % 3 == 0) divisibleBy3++;
    if (num % 4 == 0) divisibleBy4++;
}
Console.WriteLine($"{(double)divisibleBy2 / n * 100:F2}%");
Console.WriteLine($"{(double)divisibleBy3 / n * 100:F2}%");
Console.WriteLine($"{(double)divisibleBy4 / n * 100:F2}%");