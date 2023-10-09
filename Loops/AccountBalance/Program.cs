string input = Console.ReadLine();
double balance = 0;
while (input != "End")
{
    double money = double.Parse(input);

    if (money >= 0)
    {
        Console.WriteLine($"Increase: {money:F2}");
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }

    balance += money;
    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {balance:F2}");