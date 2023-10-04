int maxNumber = int.Parse(Console.ReadLine());
int firstNumber = 1;
int currentNumber = 1;
Console.WriteLine(firstNumber);
while (firstNumber < maxNumber)
{
    currentNumber = firstNumber * 2 + 1;
    if (currentNumber > maxNumber) break;
    Console.WriteLine(currentNumber);
    firstNumber = currentNumber;
}