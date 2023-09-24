string password = Console.ReadLine();
bool isValid = true;

if (!HasValidLenght(password))
{
    Console.WriteLine($"Password must be between 6 and 10 characters");
    isValid = false;
}

if (ContainsInvalidCharacters(password))
{
    Console.WriteLine($"Password must consist only of letters and digits");
    isValid = false;
}

if (!ContainsDigitCount(password, count: 2))
{
    Console.WriteLine($"Password must have at least 2 digits");
    isValid = false;
}

if (isValid)
{
    Console.WriteLine($"Password is valid");
}


static bool ContainsDigitCount(string password, int count)
{
    int foundDigitsCount = 0;

    foreach (var symbol in password)
    {
        if (char.IsDigit(symbol))
        {
            foundDigitsCount++;
            if (foundDigitsCount == count)
            {
                return true;
            }
        }
    }
    return false;
}

static bool ContainsInvalidCharacters(string password)
{
    foreach (var symbol in password)
    {
        if (!char.IsLetterOrDigit(symbol))
        {
            return true;
        }
    }
    return false;
}

static bool HasValidLenght(string password)
{
    return password.Length >= 6 && password.Length <= 10;
}