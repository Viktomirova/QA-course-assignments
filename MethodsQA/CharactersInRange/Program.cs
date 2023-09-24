
char inputFirstChar = char.Parse(Console.ReadLine());
char inputSecondChar = char.Parse(Console.ReadLine());

PrintCharactersBetween(inputFirstChar, inputSecondChar);


static void PrintCharactersBetween(char first, char second)
{
    int start = 1;
    int end;

    if (first > second)
    {
        start += second;
        end = first;
    }
    else
    {
        start += first;
        end = second;
    }

    for (int i = start; i < end; i++)
    {
        Console.Write($"{(char)i} ");
    }

    Console.WriteLine();
}