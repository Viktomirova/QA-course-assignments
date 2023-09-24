string text = Console.ReadLine();

FindMiddleCharacters(text);
static void FindMiddleCharacters(string text)
{
    if (text.Length % 2 == 0)
    {
        Console.WriteLine(text[text.Length / 2 - 1] + "" + text[text.Length / 2]);
    }
    else Console.WriteLine(text[text.Length / 2]);
}
