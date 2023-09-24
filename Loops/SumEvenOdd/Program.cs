int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
for (int i = firstNumber; i <= secondNumber; i++)
{
    string currentNumber = i.ToString();
    int oddSum = 0;
    int evenSum = 0;
    for (int j = 0; j < currentNumber.Length; j++)
    {
        int digit = int.Parse(currentNumber[j].ToString());
        if (j % 2 == 0)
        {
            evenSum += digit;
        }
        else
        {
            oddSum += digit;
        }
    }
    if (oddSum == evenSum)
    {
        Console.Write(i + " ");
    }
}