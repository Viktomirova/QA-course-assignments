List<int> numbers = new List<int>();
int startNum = 1;

while (numbers.Count < 10)
{
    try
    {
        int num = ReadNumber(startNum, 100);

        numbers.Add(num);
        startNum = num;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
    catch (ArgumentException)
    {
        Console.WriteLine($"Your number is not in range {startNum} - 100!");
    }
    if (100 - startNum == 1)
    {
        break;
    }
}

Console.WriteLine(string.Join(", ", numbers));

static int ReadNumber(int start, int end)
{
    int n = int.Parse(Console.ReadLine());

    if (n <= start || n >= end)
    {
        throw new ArgumentException();
    }

    return n;
}