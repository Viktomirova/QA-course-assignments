string input = Console.ReadLine();
while (input != "END")
{
    Console.WriteLine(IsPalindrome(input));
    input = Console.ReadLine();
}

static bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] != word[word.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}