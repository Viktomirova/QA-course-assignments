char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());

FindAllLetterCombinations(startLetter, endLetter, excludedLetter);

static void FindAllLetterCombinations(char startLetter, char endLetter, char excludedLetter)
{
    int counter = 0;
    for (char i = startLetter; i <= endLetter; i++)
    {
        for (char j = startLetter; j <= endLetter; j++)
        {
            for (char k = startLetter; k <= endLetter; k++)
            {
                if (i != excludedLetter && j != excludedLetter && k != excludedLetter)
                {
                    Console.Write($"{i}{j}{k} ");
                    counter++;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine(counter);
}