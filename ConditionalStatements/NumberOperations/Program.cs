int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
string operand = Console.ReadLine();
double result = 0;
switch (operand)
{
    case "+":
        result = number1 + number2;
        break;
    case "-":
        result = number1 - number2;
        break;
    case "*":
        result = number1 * number2;
        break;
    case "/":
        result = number1 / number2;
        break;
    default:
        break;
}
Console.WriteLine($"{number1} {operand} {number2} = {result:F2}");