int stores = int.Parse(Console.ReadLine());
int things = int.Parse(Console.ReadLine());
char type = 'L';
for (int i = stores; i > 0; i--)
{
    for (int j = 0; j < things; j++)
    {
        Console.Write($"{type}{i}{j} ");
    }
    if (i % 2 == 0)
    {
        type = 'A';
    }
    else
    {
        type = 'O';
    }
    Console.WriteLine();
}