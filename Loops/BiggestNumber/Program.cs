int n = int.Parse(Console.ReadLine());
int biggest = int.MinValue;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
	if (number > biggest) biggest = number;
}
Console.WriteLine(biggest);