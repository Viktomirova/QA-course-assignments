using System.Collections;

int number = int.Parse(Console.ReadLine());

Queue<string> result = GetDigitsFromNumber(number);
while (result.Count > 0)
{
    Console.WriteLine(result.Dequeue());
}

static Queue<string> GetDigitsFromNumber(int number)
{
    Queue<string> digitsCollection = new Queue<string>();
    while (number > 0)
    {
        int digit = number % 10;
        digitsCollection.Enqueue(GetNameOfDigit(digit));
        number /= 10;
    }
    return digitsCollection;
}
static string GetNameOfDigit(int digit)
{
    string name = "";
    switch (digit)
    {
        case 1:
        name = "one";
        break;
        case 2:
        name = "two";
        break;
        case 3:
        name = "three";
        break;
        case 4:
        name = "four";
        break;
        case 5:
        name = "five";
        break;
        case 6:
        name = "six";
        break;
        case 7:
        name = "seven";
        break;
        case 8:
        name = "eight";
        break;
        case 9:
        name = "nine";
        break;
        case 0:
        name = "zero";
        break;
    }
    return name;
}