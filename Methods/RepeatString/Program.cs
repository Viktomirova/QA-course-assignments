string text = Console.ReadLine();
int repeatCount = int.Parse(Console.ReadLine());

RepeatString(text, repeatCount);

static void RepeatString(string text, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(text);
    }
    Console.WriteLine();
}