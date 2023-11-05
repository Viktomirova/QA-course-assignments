string text = Console.ReadLine();

string digits = String.Empty;
string letters = String.Empty;
string others = String.Empty;

for (int i = 0; i < text.Length; i++)
{
    if (!Char.IsLetterOrDigit(text[i]))
    {
        others += text[i];
    }
    else if (Char.IsDigit(text[i]))

    {
        digits += text[i];
    }
    else
    {
        letters += text[i];
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);