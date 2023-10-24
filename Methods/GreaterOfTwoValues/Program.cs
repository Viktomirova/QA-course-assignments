string typeOfValues = Console.ReadLine();
string value1 = Console.ReadLine();
string value2 = Console.ReadLine();


switch (typeOfValues)
{
    case "int":
        int int1 = int.Parse(value1);
        int int2 = int.Parse(value2);
        Console.WriteLine(FindGreaterNumber(int1, int2));
        break;
    case "char":
        char ch1 = char.Parse(value1);
        char ch2 = char.Parse(value2);
        Console.WriteLine(FindGreaterChar(ch1, ch2));
        break;
    case "string":
        Console.WriteLine(FindGreaterString(value1, value2));
        break;
}

static string FindGreaterString(string str1, string str2)
{
    if (str1.CompareTo(str2) > 0)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}

static char FindGreaterChar(char ch1, char ch2)
{
    if (ch1 > ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
}

static int FindGreaterNumber(int int1, int int2)
{
    if (int1 > int2)
    {
        return int1;
    }
    else
    {
        return int2;
    }
}