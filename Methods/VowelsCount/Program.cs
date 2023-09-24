string input = Console.ReadLine();

Console.WriteLine(GetVowelCount(input));


static int GetVowelCount(string text)
{
    int count = 0;

    text = text.ToLower();

    foreach (var ch in text)
    {
        switch (ch)
        {
            case 'a':
                count++;
                break;

            case 'e':
                count++;
                break;

            case 'i':
                count++;
                break;

            case 'o':
                count++;
                break;

            case 'u':
                count++;
                break;
        }
    }

    return count;
}