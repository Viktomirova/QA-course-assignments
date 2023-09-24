int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string op = Console.ReadLine();

if (op == "+")
{
    int result = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
}
else if (op == "-")
{
    int result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
}
else if (op == "*")
{
    int result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
}
else if (op == "/")
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        double result = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:f2}");
    }
}
else if (op == "%")
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        int result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");
    }
}
