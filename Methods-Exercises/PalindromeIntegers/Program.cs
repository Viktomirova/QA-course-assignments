while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "end")
    {
        break;
    }

    Console.WriteLine(IsPalidrom(input) ? "true" : "false");
}

static bool IsPalidrom(string text)
{
    bool result = false;
    string firstHalf = "";
    string secondHalf = "";
    if (text.Length == 1)
    {
        result = true;
    }
    else if (text.Length % 2 != 0)
    {
        for (int i = 0; i < text.Length / 2; i++)
        {
            firstHalf += text[i];
        }
        for (int i = text.Length - 1; i > text.Length / 2; i--)
        {
            secondHalf += text[i];
        }
        if (firstHalf == secondHalf)
        {
            result = true;
        }
    }
    else
    {
        for (int i = 0; i < text.Length / 2; i++)
        {
            firstHalf += text[i];
        }
        for (int i = text.Length - 1; i >= text.Length / 2; i--)
        {
            secondHalf += text[i];
        }
        if (firstHalf == secondHalf)
        {
            result = true;
        }
    }
    return result;
}