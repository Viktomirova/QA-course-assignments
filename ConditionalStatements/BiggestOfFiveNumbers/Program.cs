int n = 5;
int number = 0;
int maxNumber = int.MinValue;
for (int i = 0; i < n; i++)
{
    number = int.Parse(Console.ReadLine());
    if (number > maxNumber)
    {
        maxNumber = number;
    }
}
Console.WriteLine(maxNumber);